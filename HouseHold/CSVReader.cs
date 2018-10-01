using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace HouseHold
{
  class CsvReader
  {
    public string[] Lines { get; }
    public string[] Columns { get; }
    public List<List<Object>> Data { get; }

    public CsvReader(string fileName)
    {
      string[] text = File.ReadAllLines(fileName);
      Lines = new string[text.Length - 1];
      if (text.Length > 0) Columns = SplitLine(text[0]);
      if (text.Length > 1) Lines = text.Skip(1).ToArray();

      Data = Lines.Select(l => SplitLine(l).ToList<object>()).ToList();
    }

    public string[] SplitLine(string line) => line.Remove(0,1).Split(new[] {"\",\"" },StringSplitOptions.None).ToArray();

  }
}
