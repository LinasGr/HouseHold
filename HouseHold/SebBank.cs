using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHold
{
  class SebBank : Bank
  {
    //private Dictionary<int, string> stulpeliai;

    public SebBank(string fileName)
    {
      ReadFileData(fileName);
    }

    public override void ReadFileData(string fileName)
    {
      ACCReader file = new ACCReader(fileName);
      this.data = file.data.Where(z => z[0].ToString() == "010").Select(x =>
      x.Where((xx, i) => i == 16 || i == 2 || i == 17 || i == 13 || i == 7 || i == 8 || i == 8 || i == 6).ToList<object>()).ToList();
      for (int i = 0; i < this.data.Count; i++)
      {
        this.data[i].Add(this.data[i][5]);
        this.data[i].Add((object)this.data[i][0].ToString().Insert(4,"-").Insert(7,"-"));
        this.data[i].Add(this.data[i][6]);
        this.data[i].Add(this.data[i][4]);
        this.data[i].Add(this.data[i][2].ToString().Insert(this.data[i][2].ToString().Length - 2, "."));
        this.data[i].Add(this.data[i][3]);
        this.data[i].Add(this.data[i][1]);
        this.data[i].RemoveRange(0,7);
      }
    }
  }
}
