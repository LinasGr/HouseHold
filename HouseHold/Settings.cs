using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HouseHold
{
  /// <summary>
  /// Class to habdle setup file loading and saving to file
  /// </summary>
  class Settings
  {
    private string fileName;
    public Dictionary<string,string> data;

    public Settings(string path)
    {
      this.data = new Dictionary<string, string>();
      this.fileName = path + "\\Setup.txt";
      if (File.Exists(this.fileName)) this.LoadData();
      else File.Create(this.fileName);
    }

    public void LoadData()
    {
      List<string> lines = File.ReadAllLines(this.fileName).ToList();
      lines.ForEach(x=>data.Add(x.Split(':')[0].ToString(),x.Split(':')[1].ToString()));
    }
    public void SaveData()
    {
      File.WriteAllLines(this.fileName, data.Select(x=>x.Key+":"+x.Value));
    }
  }
}
