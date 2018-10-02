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
      this.Enabled = false;
      var setupSheet = new FormSetupSheet();
      this.Hide();
      setupSheet.ShowDialog();
      this.Show();
      this.Enabled = true;
    }

    private void Button_AddBankData_Click(object sender, EventArgs e)
    {
      this.Enabled = false;
      var addBankData = new FormAddBankData();
      this.Hide();
      addBankData.ShowDialog();
      this.Show();
      this.Enabled = true;
    }

    private void Button_AddUserIBAN_Click(object sender, EventArgs e)
    {

      var addUserData = new FormAddUserIban();
      addUserData.ShowDialog();
      this.Show();
      this.Enabled = true;
    }

    private void Button_GetYourData_Click(object sender, EventArgs e)
    {
      var getYourData=new FormGetYourData();
      getYourData.ShowDialog();
    }

    private void button_AddServiceData_Click(object sender, EventArgs e)
    {
      this.Enabled = false;
      var addServiceData=new Form_AddServiceData();
      this.Hide();
      addServiceData.ShowDialog();
      this.Enabled = true;
      this.Show();
    }

    void openDialog(string toOpen)
    {

    }
  }
}
