Rubor
=====

Rubor is a Class library **C# with many Ruby features!** Our Extensions mirror ruby methods. For example, Rubor improve the Array C# with methods like "map", "join" etc!

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

Other example

```C#
[TestMethod]
public void TimesTest()
{
  var result = string.Empty;
  5.Times(f => { result += f.ToString() + " "; });
  5.Times(() => { System.Console.WriteLine("log"); });
      
  Assert.AreEqual(5, 5.Times().Count());
  Assert.AreEqual("1 2 3 4 5 ", result);
}
```


