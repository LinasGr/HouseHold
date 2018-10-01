using System.Collections.Generic;
using System.Windows.Forms;

namespace HouseHold
{
  abstract class Bank
  {
    public Dictionary<int, string> Columns { get; }
    public List<List<object>> Data { get; set; }

    public Bank()
    {
      Columns = new Dictionary<int, string>
      {
        { 1, "IBAN" },
        { 2, "Date" },
        { 3, "Recipient" },
        { 4, "Explanation" },
        { 5, "Amount" },
        { 6, "Currency" },
        { 7, "D/K" }
      };
    }
    public abstract void ReadFileData(string fileName);
    public void FillDataGridView(DataGridView dgv)
    {
      dgv.Columns.Clear();
      dgv.Rows.Clear();

      foreach (var item in Columns)
      {
        dgv.Columns.Add(item.Value, item.Value);
      }
      Data.ForEach(r => dgv.Rows.Add(r.ToArray()));
      
      for (int i = 0; i < dgv.Columns.Count; i++)
      {
        if (i == 2 || i == 3) dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        else dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
      }
    }
  }
}
