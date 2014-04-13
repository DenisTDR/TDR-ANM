using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDebugLogs
{
    public partial class LogsWindow : Form
    {
        public LogsWindow()
        {
            InitializeComponent();
            excList = new List<Exception>();
            msgs = new List<string>();
            this.Load += (object sender, EventArgs e) =>
            {
                this.Top = 50;
                this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width;
            };
        }
        ErrorWindow ew;
        List<Exception> excList;
        List<string> msgs;
        private void clearBtn_Click(object sender, EventArgs e)
        {
            logsLb.Items.Clear();
            excList.Clear();
            msgs.Clear();
        }
        public void Log(Exception exc, string msg="")
        {
            excList.Add(exc);
            msgs.Add(msg);
            if (exc == null || msg != "")
                logsLb.Items.Add(msg);
            else
                logsLb.Items.Add(exc.Message);
        }
        int lastSelected=-1;
        private void logsLb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void logsLb_MouseUp(object sender, MouseEventArgs e)
        {
            if (lastSelected != logsLb.SelectedIndex && logsLb.SelectedIndex != -1)
            {
                lastSelected = logsLb.SelectedIndex;
                ShowError(excList[lastSelected], msgs[lastSelected]);
            }
        }
        public void ShowError(Exception exc, string str)
        {
            if (ew == null)
                (ew = new ErrorWindow()).Show();
            ew.LoadExc(exc, str);
            ew.Focus();
        }

        private void LogsWindow_Load(object sender, EventArgs e)
        {

        }

        private void onTopChk_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = (sender as CheckBox).Checked;
        }
    }
}
