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
  public partial class Form_AddUserData : Form
  {
    
    public Form_AddUserData()
    {
      InitializeComponent();
    }

    private void button_Save_Click(object sender, EventArgs e)
    {
      if (this.textBox_IBAN.Text.Length > 0)
      {
        var sheet = new SheetTools.GoogleSheet("","");
      }
    }
  }
}
