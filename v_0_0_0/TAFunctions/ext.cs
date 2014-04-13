using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMySQLConnectorNS;
namespace TALibrary
{
    public static class ext
    {
        public static Account connectedAccount;
        public static TMySQLConnector tconn;

        public static bool DbConnected
        {
            get { return tconn.Connected; }
        }

        public static void initDb()
        {
            if (tconn == null)
            {
                //tconn = new TMySQLConnector("176.223.119.184", "v_0_0_1", "root", "JtJ2XVlQlcCaBin", true);
                tconn = new TMySQLConnector("localhost", "v_0_0_1", "root", "", true);
                tconn.Connect();
            }
            else if (!tconn.Connected)
                tconn.Connect();
        }
        public static void FatalErrorOcurred()
        {
            MessageBox.Show("An error ocurred and the application needs to be closed!", "Error!");
            Application.Exit();
        }
    }
}
