using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubor;
using System.Linq;
using System.Collections.Generic;

namespace Rubor.UnitTests
{
  [TestClass]
  public class IntegerTests
  {
    [TestMethod]
    public void DownToTest()
    {
      Assert.AreEqual(5, 5.DownTo(1).Count());
    }

    [TestMethod]
    public void EvenTest()
    {
      Assert.IsTrue(2.Even());
      Assert.IsFalse(3.Even());
    }

    [TestMethod]
    public void OddTest()
    {
      Assert.IsTrue(3.Odd());
      Assert.IsFalse(2.Odd());
    }

    [TestMethod]
    public void DownToTestWithBlockTest()
    {
      var result = string.Empty;
      5.DownTo(1).Do(f => { result += f.ToString(); });

      Assert.AreEqual("54321", result);
    }

    [TestMethod]
    public void NextTest()
    {
      Assert.AreEqual(4, 3.Next());
      Assert.AreEqual(0, (-1).Next());
    }

    [TestMethod]
    public void PredTest()
    {
      Assert.AreEqual(2, 3.Pred());
      Assert.AreEqual(-2, (-1).Pred());
    }

    [TestMethod]
    public void TimesTest()
    {
      var result = string.Empty;
      5.Times(f => { result += f.ToString() + " "; });
      5.Times(() => { System.Console.WriteLine("log"); });
      
      Assert.AreEqual(5, 5.Times().Count());
      Assert.AreEqual("1 2 3 4 5 ", result);
    }

    [TestMethod]
    public void UpToTest()
    {
      var result = string.Empty;
      5.UpTo(10).Do(f => { result += f + " "; });

      Assert.AreEqual(6, 5.UpTo(10).Count());
      Assert.AreEqual("5 6 7 8 9 10 ", result);
    }
  }
}
