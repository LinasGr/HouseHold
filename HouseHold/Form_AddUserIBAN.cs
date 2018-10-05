using System;
using System.Linq;
using System.Windows.Forms;

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
    }

    private void Button_Cancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void Button_PushToSheet_Click(object sender, EventArgs e)
    {
      if (textBox_IBAN.Text.Length > 0)
      {
        var sheet = new SheetTools.GoogleSheet(_settings.Data["SheetID"], "Users");
        sheet.ReadCellsData("A3:F");
        var col = new string[6];
        bool rawExist = false;
        var rowsCount = sheet.values.Values.Count;
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
  }
}
