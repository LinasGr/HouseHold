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
        this.textBox_FileName.Text = openFileDialog1.FileName;
        Bank bank = new SwedBank(openFileDialog1.FileName);
        this.dataGridView1.Columns.Clear();
        this.dataGridView1.Columns.Add("IBAN","IBAN");
        bank.FillDataGridView(this.dataGridView1);
        
      }
    }

    private void button_PushToSheet_Click(object sender, EventArgs e)
    {
      GoogleSheet sheet = new GoogleSheet("1W126R96CXLJJ7x1R14rh70RtGOEEQnJv5J7E32Jx7wI","HouseHold");
      for (int i = 0; i < this.dataGridView1.Rows.Count-1; i++)
      {
        string[] line=new string[this.dataGridView1.Rows[i].Cells.Count];
        for (int o = 0; o < this.dataGridView1.Rows[i].Cells.Count; o++)
        {
          line[o] = this.dataGridView1.Rows[i].Cells[o].Value.ToString();
        }
        sheet.CreateValuesLine(line);
      }
      sheet.AppentCellsAtEnd("A3");
    }
  }
}
