using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHold
{
  class SwedBank : Bank
  {
    private Dictionary<int, string> stulpeliai;
    private Dictionary<int, int> mapStulpeliai;

    public SwedBank(string fileName)
    {
      //mapStulpeliai = new Dictionary<int, int>();
      //mapStulpeliai.Add(1, 1);//IBAN
      //mapStulpeliai.Add(2, 3);
      //mapStulpeliai.Add(3, 4);
      //mapStulpeliai.Add(4, 5);
      //mapStulpeliai.Add(5, 6);
      //mapStulpeliai.Add(6, 7);
      //mapStulpeliai.Add(7, 8);
      ReadFileData(fileName);
    }

    public override void ReadFileData(string fileName)
    {
      CSVReader file = new CSVReader(fileName);

      this.data=(file.data.Where(z => !z.Contains("Likutis pabaigai") && !z.Contains("Apyvarta")).Select(x=>x.Where((xx,i) => i <= 7 && i !=1).ToList<object>()).ToList());

    }
  }
}
