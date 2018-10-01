using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HouseHold
{
  class AccReader
  {
    public string[] Lines { get; }
    public string[] Columns { get; }
    public List<List<Object>> Data { get; }

    public AccReader(string fileName)
    {
      string[] text = File.ReadAllLines(fileName, Encoding.GetEncoding(1257));
      Lines = new string[text.Length - 1];
      if (text.Length > 0) Columns = SplitLine(text[0]);
      if (text.Length > 1) Lines = text.Skip(1).ToArray();
      
      Data = Lines.Select(l => SplitLine(l).ToList<object>()).ToList();
    }

    public string[] SplitLine(string line) => line.Split('\t').ToArray();

  }
}
