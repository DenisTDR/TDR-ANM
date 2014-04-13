using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALibrary
{
    public static class funcs
    {
        public static string getSetting(string key)
        {
            ext.initDb();
            return ext.tconn.Value("Select value from setting where `key`=??;", new List<object>() { key }) as string;
        }
    }
}
