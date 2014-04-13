using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDebugLogs
{
    public static class TDebugLogs
    {
        static LogsWindow lw;
        public static void Log(Exception exc, string msg = "")
        {
            if (lw == null)
                (lw = new LogsWindow()).Show();
            lw.Log(exc, msg);
        }
    }
}
