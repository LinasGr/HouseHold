using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SheetTools;

namespace HouseHold
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button_BrowseFile_Click(object sender, EventArgs e)

    {
      this.progressBar_Push.Visible = false;
      BindingSource bs = new BindingSource();
      //bs.
      DialogResult browseFile = openFileDialog1.ShowDialog();
      if (browseFile == DialogResult.OK)
      {
        Bank bank;
        this.textBox_FileName.Text = openFileDialog1.FileName;
        if (openFileDialog1.FileName.EndsWith("csv"))
        {
          bank = new SwedBank(openFileDialog1.FileName);
          bank.FillDataGridView(this.dataGridView1);
        }
        if (openFileDialog1.FileName.EndsWith("acc"))
        {
          bank = new SebBank(openFileDialog1.FileName);
          bank.FillDataGridView(this.dataGridView1);
        }
      }
    }

    private void button_PushToSheet_Click(object sender, EventArgs e)
    {
      if (this.dataGridView1.Rows.Count == 0) return;
      this.progressBar_Push.Value = 0;
      this.progressBar_Push.Visible = true;
      //Using separate CPU core for data pushing
      Task<bool> upload = new Task<bool>(() =>
      {
        GoogleSheet sheet = new GoogleSheet("1W126R96CXLJJ7x1R14rh70RtGOEEQnJv5J7E32Jx7wI", "HouseHold");
        GoogleSheet filter = new GoogleSheet("1W126R96CXLJJ7x1R14rh70RtGOEEQnJv5J7E32Jx7wI", "Filter");

        //creating vallues on filter and sheet objects
        var linesCount = this.dataGridView1.Rows.Count;
        if (this.dataGridView1.AllowUserToAddRows) linesCount--;
        for (int i = 0; i < linesCount; i++)
        {
          var line = new string[this.dataGridView1.Rows[i].Cells.Count + 1];
          for (int o = 0; o < this.dataGridView1.Rows[i].Cells.Count; o++)
          {
            line[o] = this.dataGridView1.Rows[i].Cells[o].Value.ToString();
          }
          sheet.CreateValuesLine(line);
          //Adding formula on filter to check if line exist
          line[line.Length - 1] = $"=AND(" +
            $"OR(COUNTIF(HouseHold!A1:A;A{i + 1})>0;ISBLANK(A{i + 1}));" +
            $"OR(COUNTIF(HouseHold!B1:B;B{i + 1})>0;ISBLANK(B{i + 1}));" +
            $"OR(COUNTIF(HouseHold!C1:C;C{i + 1})>0;ISBLANK(C{i + 1}));" +
            $"OR(COUNTIF(HouseHold!D1:D;D{i + 1})>0;ISBLANK(D{i + 1}));" +
            $"OR(COUNTIF(HouseHold!E1:E;E{i + 1})>0;ISBLANK(E{i + 1}));" +
            $"OR(COUNTIF(HouseHold!F1:F;F{i + 1})>0;ISBLANK(F{i + 1}));" +
            $"OR(COUNTIF(HouseHold!G1:G;G{i + 1})>0;ISBLANK(G{i + 1})))";
          filter.CreateValuesLine(line);
        }
        //uploading filter values to filter sheet
        filter.UpdateCellsData("A1");

        //Reading search results from Filter sheet and cleans filter tab
        filter.ReadCellsData("H1:H" + filter.values.Values.Count);
        filter.DeleteRange("A1:H");

        //Removing dublicate raws from sheet values
        for (int i = 0; i < filter.values.Values.Count; i++)
          if (filter.values.Values[i][0].ToString() == "TRUE")
            sheet.values.Values[i].Clear();
        for (int i = sheet.values.Values.Count - 1; i >= 0; i--)
          if (sheet.values.Values[i].Count == 0) sheet.values.Values.RemoveAt(i);

        //Uploading valid data
        sheet.AppentCellsAtEnd("A3");
        return true;
      });
      this.progressBar_Push.Visible = true;
      this.progressBar_Push.Value = 50;
      //upload.ContinueWith((t) => {this.progressBar_Push.Value = 100; });
      upload.Start();
      this.progressBar_Push.Value = 100;
    }
  }
}
