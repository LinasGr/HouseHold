using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SheetTools;

namespace HouseHold
{
  public partial class FormGetYourData : Form
  {
    private Settings _settings = new Settings(Application.StartupPath);
    private static GoogleSheet sheet;
    private static GoogleSheet sheetServices;
    private static GoogleSheet sheetLists;

    public FormGetYourData()
    {
      if (!_settings.Data.ContainsKey("Name") || !_settings.Data.ContainsKey("SheetID"))
      {
        MessageBox.Show(@"Add settings for sheet and user to get data.", @"Error");
        Close();
      }
      InitializeComponent();
      FormBorderStyle = FormBorderStyle.FixedSingle;

      label_UserName.Text = _settings.Data["Name"];
      sheet = new GoogleSheet(_settings.Data["SheetID"], "UsersIBAN");
      sheetServices = new GoogleSheet(_settings.Data["SheetID"], "Services");
      sheetLists = new GoogleSheet(_settings.Data["SheetID"], "ListsData");

      //Services grid Columns creation
      sheetServices.ReadCellsData("A2:E");
      sheetServices.values.Values[0].ToList().ForEach(x =>
      {
        dataGridView_ServiceData.Columns.Add(x.ToString(), x.ToString());
        if (dataGridView_ServiceData.Columns.Count == 1) dataGridView_ServiceData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        else dataGridView_ServiceData.Columns[dataGridView_ServiceData.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
      });
      sheetServices.values.Values.RemoveAt(0);

      //Loading service dropdown box
      sheetLists.ReadCellsData("A2:A");
      sheetLists.values.Values.ToList().ForEach(x => comboBox_Services.Items.Add(x[0]));
      comboBox_Services.Text = comboBox_Services.Items[0].ToString();

      //User accounts datagrid fill
      sheet.ReadCellsData("A2:F");
      sheet.values.Values[0].ToList().ForEach(x =>
      {
        dataGridView_UserData.Columns.Add(x.ToString(), x.ToString());
        if (dataGridView_UserData.Columns.Count == 1) dataGridView_UserData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        else dataGridView_UserData.Columns[dataGridView_UserData.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
      });
      sheet.values.Values[0].Clear();
      sheet.values.Values.RemoveAt(0);
      sheet.values.Values.Where(x => x[0].ToString() == label_UserName.Text).ToList().
        ForEach(z => dataGridView_UserData.Rows.Add(z.Where(u => u.ToString() != label_UserName.Text).ToArray()));
    }

    private void Form_GetYourData_Load(object sender, EventArgs e)
    {

    }

    private void button_Close_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void LoadServices()
    {
      dataGridView_ServiceData.Rows.Clear();
      //sheetServices.ReadCellsData("A3:E");
      sheetServices.values.Values.Where(
          d => Convert.ToDateTime(d[1].ToString()) >= dateTimePicker_From.Value &&
          Convert.ToDateTime(d[1].ToString()) <= dateTimePicker_Till.Value &&
           d[0].ToString() == comboBox_Services.Text)
          .OrderByDescending(x => x[1].ToString()).ToList()
        .ForEach(s => dataGridView_ServiceData.Rows.Add(s.ToArray()));
      List<double> counterD = new List<double>();
      List<double> counterN = new List<double>();
      List<double> counterS = new List<double>();
      for (int i = 0; i < dataGridView_ServiceData.Rows.Count; i++)
      {
        counterD.Add(double.Parse(dataGridView_ServiceData.Rows[i].Cells[2].Value.ToString().Replace(',', '.')));
        counterN.Add(double.Parse(dataGridView_ServiceData.Rows[i].Cells[3].Value.ToString().Replace(',', '.')));
        counterS.Add(double.Parse(dataGridView_ServiceData.Rows[i].Cells[4].Value.ToString().Replace(',', '.')));
      }
      if (counterD.Count > 0)
        textBox_DayCounter.Text = (counterD.Max() - counterD.Min()).ToString();
      if (counterN.Count > 0)
        textBox_NiteCounter.Text = (counterN.Max() - counterN.Min()).ToString();
      if (counterS.Count > 0)
        textBox_SingleCounter.Text = (counterS.Max() - counterS.Min()).ToString();
      textBox_Total.Text = "" + (double.Parse(textBox_DayCounter.Text) +
                                 double.Parse(textBox_NiteCounter.Text) +
                                 double.Parse(textBox_SingleCounter.Text));
    }

    private void comboBox_Services_SelectedIndexChanged(object sender, EventArgs e)
    {
      LoadServices();
    }

    private void dateTimePicker_From_ValueChanged(object sender, EventArgs e)
    {
      LoadServices();
    }

    private void dateTimePicker_Till_ValueChanged(object sender, EventArgs e)
    {
      LoadServices();
    }

    private void button_Close_Click_1(object sender, EventArgs e)
    {
      Close();
    }
  }
}
