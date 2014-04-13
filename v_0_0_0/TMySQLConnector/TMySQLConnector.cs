using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TDebugLogs;
namespace TMySQLConnectorNS
{
    public class TMySQLConnector
    {
        public TMySQLConnector()
        {
            conn = new MySqlConnection();
        }
        public TMySQLConnector(string host, string db, string user, string pass, bool debugging = false)
        {
            Host = host;
            DataBaseName = db;
            User = user;
            Password = pass;
            Debugging = debugging;
            conn = new MySqlConnection();
        }
        string host, db, user, pass, connStr;
        bool debugging;
        int tmpInt;
        MySqlConnection conn;
        MySqlCommand cmd;
        #region Properties
        public string Host
        {
            get { return host; }
            set { host = value; }
        }
        public string DataBaseName
        {
            get { return db; }
            set { db = value; }
        }
        public string User
        {
            get { return user; }
            set { user = value; }
        }
        public string Password
        {
            get { return pass; }
            set { pass = value; }
        }
        public bool Debugging
        {
            get { return debugging; }
            set { debugging = value; }
        }
        
        bool connected = true;
        public bool Connected
        {
            get { return conn.State == System.Data.ConnectionState.Open; }
            set { connected = value; }
        }
        #endregion
        public bool Connect()
        {
            connStr = "Server=" + host + ";Database=" + DataBaseName + ";Uid=" + User + ";Pwd=" + Password + ";";
            conn.ConnectionString = connStr;
            TDebugLogs.TDebugLogs.Log(null, "Connecting to database...");
            try
            {
                conn.Open();
                connected = true;
                TDebugLogs.TDebugLogs.Log(null, "Conectat la baza de date!");
                return true;
            }
            catch (Exception exc)
            {
                connected = false;
                
                if (Debugging)
                    MessageBox.Show(exc.Message, "Fatal Error!");
                return false;
            }
        }
        public int NonQuery(string query, List<object> prms=null)
        {
            if (!Connected && !Connect())
                return -1;
            cmd = getParametrizedCommand(query, prms);    
            try
            {
                cmd = getParametrizedCommand(query, prms);   
                tmpInt = cmd.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                tmpInt = -1;
                TDebugLogs.TDebugLogs.Log(exc, "Error at NonQuery!");
            }
            return tmpInt;
        }
        public List<object> Column(string query, List<object> prms=null)
        {
            List<object> ret = new List<object>();
            try
            {
                cmd = getParametrizedCommand(query, prms);
                MySqlDataReader msdr = cmd.ExecuteReader();
                while (msdr.Read())
                    ret.Add(msdr[0]);
                msdr.Close();
            }
            catch (Exception exc)
            {
                Log(exc, "Eror at Column in connector!");
            }
            return ret;
        }
        public List<object> Row(string query, List<object> prms)
        {
            List<object> ret = new List<object>();
            try
            {
                cmd = getParametrizedCommand(query, prms);
                MySqlDataReader msdr = cmd.ExecuteReader();
                if (msdr.Read())
                    for (int i = 0; i < msdr.FieldCount; i++)
                        ret.Add(msdr[i]);
                while (msdr.Read()) ;
                msdr.Close();
            }
            catch (Exception exc) { Log(exc, "Eror at Row in connector!"); }
            
            
            return ret;
        }
        public int RowCount(string query, List<object> prms)
        {
            int ret=-1;
            try
            {
                cmd = getParametrizedCommand(query, prms);
                ret = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception exc)
            {
                Log(exc, "rowCount error!");
            }
            return ret;
        }
        public object Value(string query, List<object> prms)
        {
            object ret = null;
            try
            {
                ret = Row(query, prms)[0];
            }
            catch (Exception exc)
            {
                Log(exc, "Value error!");
            }
            return ret;
        }
        public List<List<object>> Get(string query, List<object> prms)
        {
            List<List<object>> loo = new List<List<object>>();
            try
            {
                cmd = getParametrizedCommand(query, prms);
                MySqlDataReader msdr = cmd.ExecuteReader();
                while (msdr.Read())
                {
                    List<object> lo = new List<object>();
                    for (int i = 0; i < msdr.FieldCount; i++)
                        lo.Add(msdr[i]);
                    loo.Add(lo);
                }
                msdr.Close();
            }
            catch (Exception exc)
            {
                Log(exc, "Get (from db) error!");
            }
            return loo;
        }
        MySqlCommand getParametrizedCommand(string query, List<object> prms)
        {
            cmd = new MySqlCommand(query, conn);
            if (prms != null)
            {
                int c = 0;
                while (query.Contains("??"))
                    query = query.Replace("??", "@var" + c++.ToString(), 1);
                cmd.CommandText = query;
                c = 0;
                foreach (object ob in prms)
                    cmd.Parameters.AddWithValue("@var" + c++.ToString(), ob);
                Log(null, query + " " + cmd.Parameters.Count.ToString());
            }
            return cmd;
        }
        void Log(Exception exc = null, string s = "")
        {
            TDebugLogs.TDebugLogs.Log(exc, s);
        }
    }
}
