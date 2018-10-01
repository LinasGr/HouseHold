using System;
using System.Linq;
using System.Windows.Forms;
using SheetTools;

namespace HouseHold
{
  public partial class FormGetYourData : Form
  {
    private Settings _settings = new Settings(Application.StartupPath);

    public FormGetYourData()
    {
      InitializeComponent();
    }

    private void Form_GetYourData_Load(object sender, EventArgs e)
    {
      if (!_settings.Data.ContainsKey("Name") || !_settings.Data.ContainsKey("SheetID"))
      {
        MessageBox.Show(@"Add settings for sheet and user to get data.", @"Error");
        Close();
      }

      label_UserName.Text = _settings.Data["Name"];
      var sheet = new GoogleSheet(_settings.Data["SheetID"], "Users");
      sheet.ReadCellsData("A2:F");
      sheet.values.Values[0].RemoveAt(0);
      sheet.values.Values[0].ToList().ForEach(x =>
          {
            dataGridView1.Columns.Add(x.ToString(), x.ToString());
            if (dataGridView1.Columns.Count == 1) dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            else dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
          });
      sheet.values.Values[0].Clear();
      sheet.values.Values.RemoveAt(0);
      sheet.values.Values.Where(x => x[0].ToString() == label_UserName.Text).ToList().
        ForEach(z => dataGridView1.Rows.Add(z.Where(u => u.ToString() != label_UserName.Text).ToArray()));
    }

    private void button_Close_Click(object sender, EventArgs e)
    {
      Close();
    }

  }
}
