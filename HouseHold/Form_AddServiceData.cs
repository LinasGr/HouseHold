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
  public partial class Form_AddServiceData : Form
  {
    private Settings settings = new Settings(Application.StartupPath);
    private GoogleSheet sheetLists;
    private GoogleSheet sheetServices;
    private int rowIndex;

    public Form_AddServiceData()
    {
      InitializeComponent();
      FormBorderStyle = FormBorderStyle.FixedSingle;
      initData();
      rowIndex = -1;
    }

    public void initData()
    {
      if (!settings.Data.ContainsKey("SheetID"))
      {
        MessageBox.Show("No SheetID provided!\nGo to SetupSheet please.", "Error", MessageBoxButtons.OK);
        Close();
      }
      sheetLists = new GoogleSheet(settings.Data["SheetID"], "ListsData");
      sheetLists.ReadCellsData("A2:A");
      sheetLists.values.Values.ToList().ForEach(x => comboBox_Services.Items.Add(x[0]));
      sheetServices = new GoogleSheet(settings.Data["SheetID"], "ServicesCounters");
      sheetServices.ReadCellsData("A3:E");
      dateTimePicker1.Value = DateTime.Now;
    }

    private void button_Close_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void FindeService()
    {
      textBox_DayCounter.Text = "" + 0;
      textBox_NiteCounter.Text = "" + 0;
      textBox_SingleCounter.Text = "" + 0;
      IList<object> raw=null;

      sheetServices.ReadCellsData("A3:E");
      if (sheetServices.values.Values != null)
        raw = sheetServices.values.Values.FirstOrDefault(x => x[1].ToString() == dateTimePicker1.Value.ToString("yyyy.MM.dd") &&
                                               x[0].ToString() == comboBox_Services.Text);
      if (raw != null)
      {
        textBox_DayCounter.Text = "" + int.Parse(raw[2].ToString());
        textBox_NiteCounter.Text = "" + int.Parse(raw[3].ToString());
        textBox_SingleCounter.Text = "" + int.Parse(raw[4].ToString());
        rowIndex = sheetServices.values.Values.IndexOf(raw);
      }
      else rowIndex = -1;
    }

    private void comboBox_Services_SelectedIndexChanged(object sender, EventArgs e)
    {
      FindeService();
    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {
      FindeService();
    }

    private void button_PushToSheet_Click(object sender, EventArgs e)
    {
      if (comboBox_Services.Text.Length == 0) return;
      if (rowIndex > -1)
      {
        for (int i = sheetServices.values.Values.Count - 1; i > -1; i--)
          if (i != rowIndex) sheetServices.values.Values.RemoveAt(i);
        sheetServices.values.Values[0][2] = textBox_DayCounter.Text;
        sheetServices.values.Values[0][3] = textBox_NiteCounter.Text;
        sheetServices.values.Values[0][4] = textBox_SingleCounter.Text;
        sheetServices.UpdateCellsData($"A{rowIndex + 3}:E{rowIndex + 3}");
      }
      else
      {
        sheetServices.ClearValues();
        sheetServices.CreateValuesLine(new string[5]{
          comboBox_Services.Text,
          dateTimePicker1.Value.ToString("yyy.MM.dd"),
          textBox_DayCounter.Text,
          textBox_NiteCounter.Text,
          textBox_SingleCounter.Text });
        sheetServices.AppentCellsAtEnd("A3:E");
      }
      sheetServices.ReadCellsData("A3:E");
    }



    private void FindeLastServiceData()
    {
      IList<object> raw;
      sheetServices.ReadCellsData("A3:E");
      raw = sheetServices.values.Values.OrderByDescending(d => d[1].ToString())
        .FirstOrDefault(s => s[0].ToString() == comboBox_Services.Text);
      if (raw != null)
      {
        textBox_DayCounter.Text = "" + double.Parse(raw[2].ToString().Replace(',', '.'));
        textBox_NiteCounter.Text = "" + double.Parse(raw[3].ToString().Replace(',', '.'));
        textBox_SingleCounter.Text = "" + double.Parse(raw[4].ToString().Replace(',', '.'));
      }
      else
        MessageBox.Show("No data for this service found.");
    }

    private void button_LoadLastServiceData_Click(object sender, EventArgs e)
    {
      if (comboBox_Services.Text.Length > 0)
        FindeLastServiceData();
    }
  }
}
