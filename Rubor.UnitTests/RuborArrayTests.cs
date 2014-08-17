using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubor;
using System.Linq;

namespace Rubor.UnitTests
{
  [TestClass]
  public class RuborArrayTests
  {
    [TestMethod]
    public void EachTests()
    {
      Rubor.RuborConsole.Clear();
      new string[] { "a", "b", "c", "d" }.Each(f =>
      {
        Rubor.RuborConsole.Write(f + " ");
      });

      var array = new string[] { "a", "b", "c", "d" }.Each().Join(",");

      Assert.AreEqual("a b c d ", Rubor.RuborConsole.Output);
      Assert.AreEqual("a,b,c,d", array);
    }

    [TestMethod]
    public void EachIndexTest()
    {
      Rubor.RuborConsole.Clear();
      new string[] { "a", "b", "c" }.EachIndex((i, f) =>
      {
        Rubor.RuborConsole.Write(i + " -- ");
      });

      var array = new string[] { "a", "b", "c", "d" }.EachIndex().Join(",");
      
      Assert.AreEqual("0 -- 1 -- 2 -- ", Rubor.RuborConsole.Output);
      Assert.AreEqual("a,b,c,d", array);
    }

    [TestMethod]
    public void EmptyTest()
    {
      Assert.IsTrue(new string[] { }.Empty());
      Assert.IsFalse(new string[] { "a", "b", "c" }.Empty());
    }

    [TestMethod]
    public void MapTest()
    {
      var array = new string[] { "a", "b", "c" }.Map(x =>{
        return x + "!";
      });

      Assert.IsTrue(new string[] { "a!", "b!", "c!" }.Eql(array));
    }

    [TestMethod]
    public void JoinTest()
    {
      var array = new string[] { "a", "b", "c" }.Join(",");
      Assert.AreEqual("a,b,c", array);
    }
  }
}
