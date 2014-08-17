using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rubor
{
  public static class RuborInteger
  {
    /// <summary>
    /// Delegate  Method
    /// </summary>
    public delegate void BlockIntParam(int value);

    /// <summary>
    /// Returns true if int is an odd number.
    /// </summary>
    public static bool Odd(this int value)
    {
      return !(value % 2).Equals(0);
    }

    /// <summary>
    /// Returns true if int is an even number.
    /// </summary>
    public static bool Even(this int value)
    {
      return (value % 2).Equals(0);

    }

    /// <summary>
    /// Returns the Integer equal to int + 1, same as #next.
    /// </summary>
    public static int Next(this int value)
    {
      return value+=1;
    }

    /// <summary>
    /// Returns the Integer equal to int - 1.
    /// </summary>
    public static int Pred(this int value)
    {
      return value -= 1;
    }

    /// <summary>
    /// Iterates the given block, passing decreasing values
    /// </summary>
    public static void Do(this IEnumerable<int> value, BlockIntParam block)
    {
      value.ToList().ForEach(x => {
        block.Invoke(x);
      });
    }

    /// <summary>
    /// Iterates the given block int times, passing in values from zero to int - 1.
    /// If no block is given, an Enumerator is returned instead.
    /// </summary>
    public static void Times(this int value, BlockIntParam block)
    {
      for (int i = 1; i <= value; i++)
        block.Invoke(i);
    }

    /// <summary>
    /// Iterates the given block int times, passing in values from zero to int - 1.
    /// If no block is given, an Enumerator is returned instead.
    /// </summary>
    public static void Times(this int value, Rubor.RuborObject.Block block)
    {
      for (int i = 1; i <= value; i++)
        block.Invoke();
    }

    /// <summary>
    /// Iterates the given block int times, passing in values from zero to int - 1.
    /// If no block is given, an Enumerator is returned instead.
    /// </summary>
    public static IEnumerable<int> Times(this int value)
    {
      for (int i = 1; i <= value; i++)
        yield return i;
    }

    /// <summary>
    /// Iterates the given block, passing decreasing values from int down to and including limit.
    /// If no block is given, an Enumerator is returned instead.
    /// </summary>
    public static IEnumerable<int> DownTo(this int value, int limit)
    {
      for (int i = value; i >= limit; i--)
        yield return i;
    }

    /// <summary>
    /// Iterates the given block, passing in integer values from int up to and including limit.
    /// If no block is given, an Enumerator is returned instead.
    /// </summary>
    public static IEnumerable<int> UpTo(this int value, int limit)
    {
      for (int i = value; i <= limit; i++)
        yield return i;
    }
  }
}
