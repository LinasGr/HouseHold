using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseHold
{
  abstract class Bank
  {
    public Dictionary<int, string> columns { get; }
    public List<List<object>> data { get; set; }

    public Bank()
    {
      columns = new Dictionary<int, string>();
      columns.Add(1, "IBAN");
      columns.Add(2, "Date");
      columns.Add(3, "Recipient");
      columns.Add(4, "Explanation");
      columns.Add(5, "Amount");
      columns.Add(6, "Currency");
      columns.Add(7, "D/K");
    }
    abstract public void ReadFileData(string fileName);
    public void FillDataGridView(DataGridView dgv)
    {
      dgv.Columns.Clear();
      dgv.Rows.Clear();

      foreach (var item in columns)
      {
        dgv.Columns.Add(item.Value, item.Value);
      }
      data.ForEach(r => dgv.Rows.Add(r.ToArray()));
      
      for (int i = 0; i < dgv.Columns.Count; i++)
      {
        if (i == 2 || i == 3) dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        else dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
      }
    }
  }
}
