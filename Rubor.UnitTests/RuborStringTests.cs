using System;
using Rubor.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rubor.UnitTests
{
  [TestClass]
  public class RuborStringTests
  {
    [TestMethod]
    public void CapitalizeTest()
    {
      var test = "test";

      Assert.AreEqual("test", test);
      Assert.AreEqual("Test", test.Capitalize());
    }

    [TestMethod]
    public void ClearTest()
    {
      var test = "test";

      Assert.AreEqual("test", test);
      Assert.AreEqual("", test.Clear());
    }

    [TestMethod]
    public void DownCaseTest()
    {
      var test = "TEST";

      Assert.AreEqual("TEST", test);
      Assert.AreEqual("test", test.DownCase());
    }

    [TestMethod]
    public void EmptyTest()
    {
      Assert.IsTrue("".Empty());
      Assert.IsFalse("test".Empty());
    }

    [TestMethod]
    public void UpCaseTest()
    {
      Assert.AreEqual("TEST","test".UpCase());
    }

    [TestMethod]
    public void ReverseTest()
    {
      Assert.AreEqual("uoiea", "aeiou".Reverse());
    }
  }
}
