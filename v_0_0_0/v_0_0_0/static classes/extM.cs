using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using v_0_0_0;
using TALibrary;
public static class extM
{
    public static mainForm mf;
    public static List<Category> categories;
    public static List<Product> products;
    public static void Log(Exception exc, string msg)
    {
        TDebugLogs.TDebugLogs.Log(exc, msg);
    }

}