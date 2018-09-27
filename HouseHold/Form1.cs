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
      GoogleSheet sheet = new GoogleSheet("1W126R96CXLJJ7x1R14rh70RtGOEEQnJv5J7E32Jx7wI", "HouseHold");
      GoogleSheet filter = new GoogleSheet("1W126R96CXLJJ7x1R14rh70RtGOEEQnJv5J7E32Jx7wI", "Filter");

      //creating filter vallues
      for (int i = 0; i < this.dataGridView1.Rows.Count - 1; i++)
      {
        var line = new string[this.dataGridView1.Rows[i].Cells.Count + 1];
        for (int o = 0; o < this.dataGridView1.Rows[i].Cells.Count; o++)
        {
          line[o] = this.dataGridView1.Rows[i].Cells[o].Value.ToString();
        }
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

      //copy of all filter values to sheet values(not referent)
      for (int i = 0; i < filter.values.Values.Count; i++)
      {
        sheet.values.Values.Add(new List<object>());
        for (int u = 0; u < filter.values.Values[i].Count - 1; u++)
        {
          sheet.values.Values[i].Add(filter.values.Values[i][u].ToString());
        }
      }

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
    }
  }
}
