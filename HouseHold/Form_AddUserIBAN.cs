using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using SheetTools;

namespace HouseHold
{
  public partial class FormAddUserIban : Form
  {

    private Settings _settings = new Settings(Application.StartupPath);

    public FormAddUserIban()
    {
      InitializeComponent();
      FormBorderStyle = FormBorderStyle.FixedSingle;
    }



    private void Form_AddUserIBAN_Load(object sender, EventArgs e)
    {
      if (!_settings.Data.ContainsKey("SheetID"))
      {
        MessageBox.Show(this, "No SheetID selected!\nPlease go to Setup Sheet.", "Error", MessageBoxButtons.OK);
        Close();
      }
      if (!_settings.Data.ContainsKey("Name"))
      {
        MessageBox.Show(this, "No use Name selected!\nPlease go to Setup Sheet.", "Error", MessageBoxButtons.OK);
        Close();
      }
      label_User.Text = _settings.Data["Name"];
      var columns = new ColumnList();
      var columnsSheet = new GoogleSheet(_settings.Data["SheetID"], "HouseHold");
      columnsSheet.ReadCellsData("A3:A");
      columns.ExtractList(columnsSheet.values.Values);
      columns.List.ForEach(x => comboBox_IBAN.Items.Add(x));
    }

    private void Button_Cancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void Button_PushToSheet_Click(object sender, EventArgs e)
    {
      if (textBox_IBAN.Text.Length > 0)
      {
        var sheet = new SheetTools.GoogleSheet(_settings.Data["SheetID"], "UsersIBAN");
        sheet.ReadCellsData("A3:F");
        var col = new string[6];
        bool rawExist = false;
        var rowsCount = 0;
        if (sheet.values.Values != null) rowsCount = sheet.values.Values.Count;
        if (rowsCount > 0)
        {
          rowsCount = 3 + sheet.values.Values.Count;
          for (int i = 0; i < sheet.values.Values.Count; i++)
            if (sheet.values.Values[i][2].ToString() == textBox_IBAN.Text)
            {
              rowsCount = i + 3;
              col = sheet.values.Values[i].Select(x => x.ToString()).ToArray();
              rawExist = true;
            }
        }
        else rowsCount = 3;
        col[0] = _settings.Data["Name"];
        col[1] = textBox_Explanation.Text;
        col[2] = textBox_IBAN.Text;
        col[3] = $"=F{rowsCount}-E{rowsCount}";
        col[4] = $"=sumifs(HouseHold!$E$3:$E;HouseHold!$A$3:$A;$C{rowsCount};HouseHold!$G$3:$G;E$2)";
        col[5] = $"=sumifs(HouseHold!$E$3:$E;HouseHold!$A$3:$A;$C{rowsCount};HouseHold!$G$3:$G;F$2)";
        sheet.ClearValues();
        sheet.CreateValuesLine(col);
        if (rawExist)
        {
          if (MessageBox.Show("IBAN already exist in sheet.", "Want to update record?",
          MessageBoxButtons.YesNo) == DialogResult.Yes)
            sheet.UpdateCellsData($"A{rowsCount}:F{rowsCount}");
        }
        else sheet.AppentCellsAtEnd("A3:F");
      }
    }

    private void comboBox_IBAN_SelectedIndexChanged(object sender, EventArgs e)
    {
      textBox_IBAN.Text = comboBox_IBAN.Text;
      if (comboBox_IBAN.Text.Length > 0)
      {
        var columns = new ColumnList();
        var columnsSheet = new GoogleSheet(_settings.Data["SheetID"], "HouseHold");
        columnsSheet.ReadCellsData("A3:C");
        IList<IList<object>> tmpList = new List<IList<object>>();
        columnsSheet.values.Values.ToList().ForEach(z =>
        {
          if (z.Count == 3) tmpList.Add(new string[] { z[2].ToString(), z[0].ToString() });
        });
        columns.ExtractList(tmpList
          , comboBox_IBAN.Text);
        columns.List.ForEach(x => comboBox_Explanation.Items.Add(x));
      }
    }

    private void comboBox_Explanation_SelectedIndexChanged(object sender, EventArgs e)
    {
      textBox_Explanation.Text = comboBox_Explanation.Text;
    }
  }
}
