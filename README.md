RUBOR
=====
![rubor_logo](http://ycodeteam.github.io/Rubor/images/rubor_logo.png)

>Rubor is a Class library **C# with many Ruby features!** Our Extensions mirror ruby methods. For example, Rubor improve >the Array C# with methods like "map", "join" etc!

How To Install
------
To install Rubor, run the following command in the 
[Package Manager Console](https://www.nuget.org/packages/Rubor/)
```
PM> Install-Package Rubor
```

Members Of Rubor
------

View in Object Browser all Members of Rubor!

```
+ Rubor
    + Core
        RuborArray.cs
        RuborInteger.cs
        RuborRange.cs
        ...
    + Objects
        Range
        ...
    + Tools
        RuborConsole.cs
        ...
```

See the Object Browser example

```C#
//Class
Rubor.Core.RuborInteger

//Object Browser
public static void Times(this int value, Rubor.RuborInteger.BlockIntParam block)
    Member of Rubor.RuborInteger

Summary:
Iterates the given block int times, passing in values from zero to int - 1.  
If no block is given, an Enumerator is returned instead.

```

How To Use
------
Import Rubor in your class

```C#
using Rubor.Core
using Rubor.Objects
```
Rubor improve the Array C# with methods like "map", "join" etc! See some examples

```C#

// Map
new string[] { "a", "b", "c" }.Map(x =>{ return x + "!"; });

// Eql
new string[] { "a!", "b!", "c!" }.Eql(array);

// Join
new string[] { "a", "b", "c" }.Join(",");

// Times
5.Times(x => { Console.Write(x); });

// Range
"1..10".Range().Begin();

```
Testing with Rubor

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

[TestMethod]
public void TimesTest()
{
  var result = string.Empty;
  5.Times(f => { result += f.ToString() + " "; });
  Assert.AreEqual("1 2 3 4 5 ", result);
}

```


