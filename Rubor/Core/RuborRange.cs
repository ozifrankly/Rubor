using Rubor.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rubor.Core
{
  public static class RuborRange
  {
    public static Range Range(this string value)
    {
      if(value.Success())
        return new Range(value.First(), value.Last());
      return null;
    }

    private static bool Success(this string value)
    {
      return new Regex("\\d*..\\d*").Match(value).Success;
    }

    private static int First(this string value)
    {
      var matches = new Regex("\\d*..").Matches(value);
      return int.Parse(matches[0].Value.Replace("..", string.Empty));
    }

    private static int Last(this string value)
    {
      var matches = new Regex("\\d*..").Matches(value);
      return int.Parse(matches[1].Value.Replace("..", string.Empty));
    }
  }
}
