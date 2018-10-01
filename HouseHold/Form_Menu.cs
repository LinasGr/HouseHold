using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseHold
{
  public partial class Form_Menu : Form
  {
    public Form_Menu()
    {
      InitializeComponent();
    }

    private void button_SetupSheet_Click(object sender, EventArgs e)
    {
      var setupSheet = new Form_SetupSheet();
      this.ActivateMdiChild(setupSheet);
      setupSheet.ShowDialog();
    }

    private void button_AddBankData_Click(object sender, EventArgs e)
    {
      var AddBankData = new Form_AddBankData();
      this.ActivateMdiChild(AddBankData);
      AddBankData.ShowDialog();
    }

    private void button_AddUserIBAN_Click(object sender, EventArgs e)
    {
      var AddUserData = new Form_AddUserIBAN();
      this.ActivateMdiChild(AddUserData);
      AddUserData.ShowDialog();
    }
  }
}
