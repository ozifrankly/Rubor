using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubor.Tools
{
  public class RuborConsole
  {
    public static string Output { get; private set; }

    public static void Clear()
    {
      Output = string.Empty;
    }

    public static void Write(string value)
    {
      Output += value;
    }
  }
}
