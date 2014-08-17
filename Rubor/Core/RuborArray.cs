using System;
using System.Collections.Generic;
using System.Linq;

namespace Rubor.Core
{
  public static class RuborArray
  {
    public delegate void RuborArrayBlock(object block);
    public delegate object RuborArrayBlockMap(object block);
    public delegate void RuborArrayIndexBlock(int index, object block);

    /// <summary>
    /// Calls the given block once for each element in self, passing that element as a parameter.
    /// An Enumerator is returned if no block is given.
    /// </summary>
    public static IEnumerable<object> Each(this IEnumerable<object> values)
    {
      foreach (var value in values)
        yield return value;
    }

    /// <summary>
    /// Same as #each, but passes the index of the element instead of the element itself.
    /// An Enumerator is returned if no block is given.
    /// </summary>
    public static IEnumerable<object> EachIndex(this IEnumerable<object> values)
    {
      return values.Each();
    }

    /// <summary>
    /// Calls the given block once for each element in self, passing that element as a parameter.
    /// An Enumerator is returned if no block is given.
    /// </summary>
    public static void Each(this IEnumerable<object> values, RuborArrayBlock block)
    {
      values.ToList().ForEach(x => { block.Invoke(x); });
    }

    /// <summary>
    /// Same as #each, but passes the index of the element instead of the element itself.
    /// An Enumerator is returned if no block is given.
    /// </summary>
    public static void EachIndex(this IEnumerable<object> values, RuborArrayIndexBlock block)
    {
      for (int i = 0; i < values.Count(); i++)
        block.Invoke(i, values.ToArray()[i]);
    }

    /// <summary>
    /// Invokes the given block once for each element of self, replacing the element with the value returned by the block
    /// </summary>
    public static IEnumerable<object> Map(this IEnumerable<object> values, RuborArrayBlockMap block)
    {
      foreach (var value in values)
        yield return block.Invoke(value);
    }

    /// <summary>
    /// Returns true if self contains no elements.
    /// </summary>
    public static bool Empty(this IEnumerable<object> values)
    {
      return values.Count().Equals(0);
    }

    /// <summary>
    /// Returns true if self and other are the same object, or are both arrays with the same content (according to Object#eql?).
    /// </summary>
    public static bool Eql(this IEnumerable<object> values, IEnumerable<object> other)
    {
      return values.Equals(other) || values.SequenceEqual(other);
    }

    /// <summary>
    /// Returns a string created by converting each element of the array to a string, separated by the given separator. If the separator is nil, it uses current $,. If both the separator and $, are nil, it uses empty string.
    /// </summary>
    public static string Join(this IEnumerable<object> values, string separator)
    {
      return values.Aggregate((x, y) => { return x + separator + y; }).ToString();
    }

    /// <summary>
    /// Returns a new array with elements of self shuffled.
    /// </summary>
    public static IEnumerable<object> Shuffle(this IEnumerable<object> values)
    {
      var rnd = new Random();
      return values.OrderBy(item => rnd.Next());
    }
  }
}
