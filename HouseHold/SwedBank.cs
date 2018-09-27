using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHold
{
  class SwedBank : Bank
  {
    //private Dictionary<int, string> stulpeliai;

    public SwedBank(string fileName)
    {
      ReadFileData(fileName);
    }

    public override void ReadFileData(string fileName)
    {
      CSVReader file = new CSVReader(fileName);

      this.data=(file.data.Where(z => !z.Contains("Likutis pabaigai") && !z.Contains("Apyvarta")).Select(x=>x.Where((xx,i) => i <= 7 && i !=1).ToList<object>()).ToList());

    }
  }
}
