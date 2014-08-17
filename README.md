RUBOR
=====
Rubor is a Class library **C# with many Ruby features!** Our Extensions mirror ruby methods. For example, Rubor improve the Array C# with methods like "map", "join" etc!

How to install
------
To install Rubor, run the following command in the Package Manager Console
```
PM> Install-Package Rubor
```

More
------
For example, Rubor improve the Array C# with methods like "map", "join" etc!

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

"Times" is other cool feature

```C#
[TestMethod]
public void TimesTest()
{
  var result = string.Empty;
  5.Times(f => { result += f.ToString() + " "; });
  Assert.AreEqual("1 2 3 4 5 ", result);
}
```


