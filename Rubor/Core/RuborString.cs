using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubor.Core
{
  public static class RuborString
  {
    /// <summary>
    /// Returns a copy of str with the first character 
    /// converted to uppercase and the remainder to lowercase. 
    /// Note: case conversion is effective only in ASCII region.
    /// </summary>
    public static string Capitalize(this string value)
    {
      return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
    }

    /// <summary>
    /// Makes string empty.
    /// </summary>
    public static string Clear(this string value)
    {
      return string.Empty;
    }

    /// <summary>
    /// Returns a copy of str with all uppercase letters replaced with 
    /// their lowercase counterparts. The operation is locale 
    /// insensitive—only characters “A” to “Z” are affected. 
    /// Note: case replacement is effective only in ASCII region.
    /// </summary>
    public static string DownCase(this string value)
    {
      return value.ToLower();
    }

    /// <summary>
    /// Returns true if str has a length of zero.
    /// </summary>
    public static bool Empty(this string value)
    {
      return string.IsNullOrEmpty(value);
    }

    /// <summary>
    /// pcases the contents of str, returning nil 
    /// if no changes were made. Note: case replacement 
    /// is effective only in ASCII region.
    /// </summary>
    public static string UpCase(this string value)
    {
      return value.ToUpper();
    }
  }
}
