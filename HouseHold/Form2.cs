using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace HouseHold
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }

    private void button_OK_Click(object sender, EventArgs e)
    {
      var filePath = Application.StartupPath + "\\Setup.txt";
      string[] data = new string[2];
      data[0] = "Name:" + this.textBox_Name.Text;
      data[1] = "SheetID:" + Regex.Match( this.textBox_SheetID.Text, "/spreadsheets/d/([a-zA-Z0-9-_]+)").Groups[1];
      File.WriteAllLines(filePath, data);
      this.Close();
    }

    private void button_Cancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void label_SheetID_Click(object sender, EventArgs e)
    {
      
    }

    private void Form2_Activated(object sender, EventArgs e)
    {
      var filePath = Application.StartupPath + "\\Setup.txt";
      if (File.Exists(filePath))
      {
        string[] data = File.ReadAllLines(filePath);
        this.textBox_SheetID.Text = data[1].Split(':')[1];
        this.textBox_Name.Text = data[0].Split(':')[1];
      }
      
    }
  }
}
