Rubor
=====

Rubor - Is a Class Library C# with many features on Ruby language! Our Extensions classes mirrow ruby methods. For example, Rubor improve C# Array class with methods like "map", "join"!

```C#
[TestMethod]
public void MapTest()
{
  var array = new string[] { "a", "b", "c" }.Map(x =>{ return x + "!"; });
  Assert.IsTrue(new string[] { "a!", "b!", "c!" }.Eql(array));
}
    
[TestMethod]
public void JoinTest()
{
  var array = new string[] { "a", "b", "c" }.Join(",");
  Assert.AreEqual("a,b,c", array);
}    
```


