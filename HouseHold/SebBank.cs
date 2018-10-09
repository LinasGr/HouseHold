using System.Linq;

namespace HouseHold
{
  /// <summary>
  /// SebBank file parser to Base bank
  /// </summary>
 
  class SebBank : Bank
  {
    public SebBank(string fileName) => ReadFileData(fileName);

    //Parse data from file to base bank
    public sealed override void ReadFileData(string fileName)
    {
      AccReader file = new AccReader(fileName);
      Data = file.Data.Where(z => z[0].ToString() == "010").Select(x =>
      x.Where((xx, i) => i == 16 || i == 2 || i == 17 || i == 13 || i == 7 || i == 8 || i == 8 || i == 6).ToList()).ToList();
      for (int i = 0; i < Data.Count; i++)
      {
        Data[i].Add(Data[i][5]);
        Data[i].Add(Data[i][0].ToString().Insert(4, "-").Insert(7, "-"));
        Data[i].Add(Data[i][6]);
        Data[i].Add(Data[i][4]);
        Data[i].Add(Data[i][2].ToString().Insert(Data[i][2].ToString().Length - 2, ","));
        Data[i].Add(Data[i][3]);
        Data[i].Add(Data[i][1]);
        Data[i].RemoveRange(0, 7);
      }
    }
  }
}
