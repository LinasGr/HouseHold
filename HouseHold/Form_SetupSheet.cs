using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SheetTools;

namespace HouseHold
{
  public partial class FormSetupSheet : Form
  {
    private Settings _settings = new Settings(Application.StartupPath);

    public FormSetupSheet()
    {
      InitializeComponent();
      FormBorderStyle = FormBorderStyle.FixedSingle;
    }

    private void Button_OK_Click(object sender, EventArgs e)
    {
      SheetIdRegex(sender, e);
      if (textBox_Name.Text.Length > 0)
        if (_settings.Data.ContainsKey("Name")) _settings.Data["Name"] = textBox_Name.Text;
        else _settings.Data.Add("Name",textBox_Name.Text);
      if (textBox_SheetID.Text.Length > 0)
        if (_settings.Data.ContainsKey("SheetID")) _settings.Data["SheetID"] = textBox_SheetID.Text;
        else _settings.Data.Add("SheetID",textBox_SheetID.Text);
      _settings.SaveData();
      Close();
    }

    private void Button_Cancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void UserDataLoad(DataGridView dgv)
    {
      var sheetUsers = new GoogleSheet(textBox_SheetID.Text, "Users");
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

    private void Button_Save_Click(object sender, EventArgs e)
    {
      UserDataLoad(dataGridView_Setup);
    }

    private void DataGridView_Setup_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (Name.Length > 0 && textBox_SheetID.Text.Length > 0)
      {
        UserDataLoad(dataGridView_Setup);
      }
    }

    private void Form_SetupSheet_Load(object sender, EventArgs e)
    {
      if (_settings.Data.ContainsKey("SheetID"))
        textBox_SheetID.Text = _settings.Data["SheetID"];
      if (_settings.Data.ContainsKey("Name"))
        textBox_Name.Text = _settings.Data["Name"];
    }

    private void SheetIdRegex(object sender, EventArgs e)
    {
      if (textBox_SheetID.Text.Length > 0)
      {
        Match rMatch = Regex.Match(textBox_SheetID.Text, @"/spreadsheets/d/([a-zA-Z0-9-_]+)", RegexOptions.IgnoreCase);
        if (rMatch.Success) textBox_SheetID.Text = rMatch.Groups[0].Value.Substring(16);
      }
    }
  }
}
