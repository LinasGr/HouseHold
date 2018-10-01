using System;
using System.Windows.Forms;

namespace HouseHold
{
  public partial class FormMenu : Form
  {
    public FormMenu()
    {
      InitializeComponent();
    }

    private void Button_SetupSheet_Click(object sender, EventArgs e)
    {
      var setupSheet = new FormSetupSheet();
      ActivateMdiChild(setupSheet);
      setupSheet.ShowDialog();
    }

    private void Button_AddBankData_Click(object sender, EventArgs e)
    {
      var addBankData = new FormAddBankData();
      //this.ActivateMdiChild(AddBankData);
      //AddBankData.Location=new Point(200, 0);
      //this.Controls.Add(AddBankData);
      //AddBankData.StartPosition = FormStartPosition.CenterParent;
      addBankData.ShowDialog();
    }

    private void Button_AddUserIBAN_Click(object sender, EventArgs e)
    {
      var addUserData = new FormAddUserIban();
      ActivateMdiChild(addUserData);
      addUserData.ShowDialog();
    }

    private void Button_GetYourData_Click(object sender, EventArgs e)
    {
      var getYourData=new FormGetYourData();
      getYourData.ShowDialog();
    }
  }
}
