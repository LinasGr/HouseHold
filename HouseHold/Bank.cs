using System.Collections.Generic;
using System.Windows.Forms;

namespace HouseHold
{
  /// <summary>
  /// Base bank data format holder
  /// </summary>
  abstract class Bank
  {
    //Default columns format
    public Dictionary<int, string> Columns { get; }

    //Data list according columns
    public List<List<object>> Data { get; set; }

    public Bank()
    {
      Columns = new Dictionary<int, string>
      {
        { 1, "IBAN" },//Bank account
        { 2, "Date" },//Date of transaction
        { 3, "Recipient" },//Who gets money
        { 4, "Explanation" },//Reason of transaction
        { 5, "Amount" },// Yeah
        { 6, "Currency" },//EUR,USD,ETC
        { 7, "D/C" }//Debit or Credit
      };
    }


    //Method to read bank data file
    public abstract void ReadFileData(string fileName);

    //Filling DataGridView in windows form with data from file or sheet
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
