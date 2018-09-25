using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HouseHold
{
  class CSVReader
  {
    public string[] lines { get; }
    public string[] columns { get; }
    public List<List<Object>> data { get; }

    public CSVReader(string fileName)
    {
      string[] text = File.ReadAllLines(fileName);
      lines = new string[text.Length - 1];
      if (text.Length > 0) columns = SplitLine(text[0]);
      if (text.Length > 1) lines = text.Skip(1).ToArray();
      
      data = lines.Select(l => SplitLine(l).ToList<object>()).ToList();
    }

    public string[] SplitLine(string line) => line.Split(',').Select(x => x.Trim('"')).ToArray();



  }
}
