using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace HouseHold
{
  /// <summary>
  /// Class to handle setup file loading and saving to file
  /// </summary>
  class Settings
  {
    private string _fileName;
    public Dictionary<string, string> Data;

    public Settings(string path)
    {
      Data = new Dictionary<string, string>();
      _fileName = path + "\\Setup.txt";
      if (File.Exists(_fileName)) LoadData();
      else File.Create(_fileName);
    }
    
    //Load settings from file
    public void LoadData()
    {
      List<string> lines = File.ReadAllLines(_fileName).ToList();
      if (lines.Count > 0)
        lines.ForEach(x => Data.Add(x.Split(':')[0].ToString(), x.Split(':')[1].ToString()));
    }

    //Save settings to file
    public void SaveData()
    {
      File.WriteAllLines(_fileName, Data.Select(x => x.Key + ":" + x.Value));
    }
  }
}
