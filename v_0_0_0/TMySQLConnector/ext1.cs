using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace TMySQLConnectorNS
{
    public static class extensions
    {
        public static string Replace(this string str, string oldValue, string newValue, int times)
        {
            return new Regex(Regex.Escape(oldValue)).Replace(str, newValue, 1);
        }
    }
}
