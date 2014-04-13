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
        static bool debugging = true;
        public static void Log(Exception exc, string msg = "")
        {
            if (!debugging)
                return;
            if (lw == null)
                (lw = new LogsWindow()).Show();
            lw.Log(exc, msg);
        }
    }
}
