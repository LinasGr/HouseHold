using Microsoft.VisualStudio.TestTools.UnitTesting;
using HouseHold;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHold.Tests
{
  [TestClass()]
  public class ColumnListTests
  {
    //[TestMethod()]
    //public void ColumnListTest()
    //{
    //  Assert.Fail();
    //}

    [TestMethod()]
    public void ExtractListTest()
    {
      IList<IList<object>> data = new List<IList<object>>();
      data.Add(new List<object>());
      data[0].Add("Str1");
      data.Add(data[0]);
      data.Add(new List<object>());
      data[2].Add("Str2");
      var columns = new ColumnList();
      columns.ExtractList(data);
      Assert.IsTrue(columns.List[0].Equals("Str1") && columns.List[1].Equals("Str2"));
    }

    [TestMethod()]
    public void ExtractListTestOverload1()
    {
      IList<IList<object>> data = new List<IList<object>>();
      data.Add(new List<object>());
      data[0].Add("Str1");
      data[0].Add("1");
      data.Add(data[0]);
      data.Add(new List<object>());
      data[2].Add("Str2");
      data[2].Add("2");
      var columns = new ColumnList();
      columns.ExtractList(data, "1");
      Assert.IsTrue(columns.List[0] == "Str1" && columns.List.Count == 1);
    }
  }
}