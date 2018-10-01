using System.Linq;

namespace HouseHold
{
  class SwedBank : Bank
  {
    //private Dictionary<int, string> stulpeliai;

    public SwedBank(string fileName)
    {
      ReadFileData(fileName);
    }

    public sealed override void ReadFileData(string fileName)
    {
      CsvReader file = new CsvReader(fileName);

      Data=(file.Data.Where(z => !z.Contains("Likutis pabaigai") && !z.Contains("Apyvarta")).Select(x=>x.Where((xx,i) => i <= 7 && i !=1).ToList()).ToList());
      //for (int i = 0; i < this.data.Count; i++)
      //{
      //  this.data[i][4] = (object)this.data[i][4].ToString().Replace('.',',');
      //  if (this.data[i][6] == "K") this.data[i][6] = "C";
      //}

      Data.ForEach(d => {
        d[4]= d[4].ToString().Replace('.', ',');
        if (d[6].ToString() == "K") d[6] = "C";
      });
    }
  }
}
