using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SheetTools;

namespace HouseHold
{
  public class ColumnList
  {
    public List<string> List = new List<string>();

    /// <summary>
    /// Loads to List data from column[0]
    /// </summary>
    /// <param name="column"></param>
    public void ExtractList(IList<IList<object>> column)
    {
      foreach (var cell in column)
      {
        if (!List.Contains(cell[0].ToString())) List.Add(cell[0].ToString() );
      }
    }

    /// <summary>
    /// Loads to List data from column[x][0] by filtering column[x][1]
    /// </summary>
    /// <param name="column"></param>
    /// <param name="filter"></param>
    public void ExtractList(IList<IList<object>> column, string filter)
    {
      foreach (var cell in column)
      {
        if (!List.Contains(cell[0].ToString())&& cell[1].ToString()==filter) List.Add(cell[0].ToString());
      }
    }
  }
}
