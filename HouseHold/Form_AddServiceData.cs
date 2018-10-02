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

    public Form_AddServiceData()
    {
      InitializeComponent();
     
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
      sheetServices = new GoogleSheet(settings.Data["SheetID"], "Services");
      sheetServices.ReadCellsData("A3:E");
      dateTimePicker1.Value = DateTime.Now;
    }

    private void Form_AddServiceData_Load(object sender, EventArgs e)
    {
      
    }

    private void button_Close_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void FindeService()
    {
      IList<object> raw;
      raw=sheetServices.values.Values.FirstOrDefault(x => x[1].ToString() == dateTimePicker1.Value.ToString("yyyy.MM.dd") &&
                                           x[0].ToString()==comboBox_Services.Text);
      if (raw!=null)
      {
        numericUpDown_DayCounter.Value = int.Parse(raw[2].ToString());
        numericUpDown_NiteCounter.Value = int.Parse(raw[3].ToString());
        numericUpDown_SingleCounter.Value = int.Parse(raw[4].ToString());
      }
    }

    private void comboBox_Services_SelectedIndexChanged(object sender, EventArgs e)
    {
      FindeService();
    }
  }
}
