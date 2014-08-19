using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubor.Core;

namespace Rubor.UnitTests
{
  [TestClass]
  public class RuborRangeTests
  {
    [TestMethod]
    public void BeginTests()
    {
      Assert.AreEqual(1, "1..10".Range().Begin());
    }
  }
}
