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
  public partial class Form_SetupSheet : Form
  {
    private Settings settings = new Settings(Application.StartupPath);

    public Form_SetupSheet()
    {
      InitializeComponent();
    }

    private void button_OK_Click(object sender, EventArgs e)
    {
      this.SheetIDRegex(sender,e);
      if (this.textBox_Name.Text.Length > 0) this.settings.data["Name"] = this.textBox_Name.Text;
      if (this.textBox_SheetID.Text.Length > 0) this.settings.data["SheetID"] = this.textBox_SheetID.Text;
      this.settings.SaveData();
    }

    private void button_Cancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void UserDataLoad(DataGridView dgv)
    {
      var sheetUsers = new SheetTools.GoogleSheet(this.textBox_SheetID.Text, "Users");
      sheetUsers.ReadCellsData("A2:F");
      dgv.Columns.Clear();
      dgv.Rows.Clear();
      foreach (var item in sheetUsers.values.Values[0])
      {
        dgv.Columns.Add(item.ToString(), item.ToString());
        if (dgv.Columns.Count < 3) dgv.Columns[dgv.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        else dgv.Columns[dgv.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

      }
      sheetUsers.values.Values[0].Clear();
      sheetUsers.values.Values.RemoveAt(0);
      //sheetUsers.values.Values.Select(r => dgv.Rows.Add(r.ToArray()));
      for (int i = 0; i < sheetUsers.values.Values.Count; i++)
      {
        dgv.Rows.Add(sheetUsers.values.Values[i].ToArray());
      }
    }

    private void button_Save_Click(object sender, EventArgs e)
    {
      this.UserDataLoad(this.dataGridView_Setup);
    }

    private void dataGridView_Setup_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.Name.Length > 0 && this.textBox_SheetID.Text.Length > 0)
      {
        this.UserDataLoad(this.dataGridView_Setup);
      }
    }

    private void Form_SetupSheet_Load(object sender, EventArgs e)
    {
      if (settings.data.ContainsKey("SheetID"))
        this.textBox_SheetID.Text = settings.data["SheetID"];
      if (settings.data.ContainsKey("Name"))
        textBox_Name.Text = settings.data["Name"];
    }

    private void SheetIDRegex(object sender, EventArgs e)
    {
      if (this.textBox_SheetID.Text.Length > 0)
      {
        Match rMatch = Regex.Match(textBox_SheetID.Text, @"/spreadsheets/d/([a-zA-Z0-9-_]+)", RegexOptions.IgnoreCase);
        if (rMatch.Success) this.textBox_SheetID.Text = rMatch.Groups[0].Value.Substring(16);
      }
    }
  }
}
