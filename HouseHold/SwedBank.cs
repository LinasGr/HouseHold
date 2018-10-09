using System.Linq;

namespace HouseHold
{
  /// <summary>
  /// SwedBank file parser to Base bank
  /// </summary>
  
  class SwedBank : Bank
  {

    public SwedBank(string fileName) => ReadFileData(fileName);

    //Parse data from file to base bank
    public sealed override void ReadFileData(string fileName)
    {
      CsvReader file = new CsvReader(fileName);

      Data = (file.Data.Where(z => !z.Contains("Likutis pabaigai") && !z.Contains("Apyvarta")).Select(x => x.Where((xx, i) => i <= 7 && i != 1).ToList()).ToList());
      Data.ForEach(d =>
      {
        d[4] = d[4].ToString().Replace('.', ',');
        if (d[6].ToString() == "K") d[6] = "C";
      });
    }
  }
}
