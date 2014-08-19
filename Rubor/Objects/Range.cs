using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubor.Objects
{
  public class Range
  {
    private object start, end;

    public Range(object start, object end)
    {
      this.start = start;
      this.end = end;
    }

    /// <summary>
    /// Returns the object that defines the beginning of the range.
    /// </summary>
    public object Begin()
    {
      return start;
    }
  }
}
