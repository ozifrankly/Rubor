RUBOR
=====
![rubor_logo](http://ycodeteam.github.io/Rubor/images/rubor_logo.png)

>Rubor is a Class library **C# with many Ruby features!** Our Extensions mirror ruby methods. For example, Rubor improve >the Array C# with methods like "map", "join" etc!

How to install
------
To install Rubor, run the following command in the Package Manager Console
```
PM> Install-Package Rubor
```

View in Object Browser all Members of Rubor!
```
+ Rubor
    + Core
        RuborArray.cs
        RuborInteger.cs
        ***
        
   + Tools
        RuborConsole.cs
        ***
  
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

//Object Browser
public static void Times(this int value, Rubor.RuborInteger.BlockIntParam block)
    Member of Rubor.RuborInteger

Summary:
Iterates the given block int times, passing in values from zero to int - 1.  If no block is given, an Enumerator is returned instead.

```


