using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
