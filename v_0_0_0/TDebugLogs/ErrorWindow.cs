using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TDebugLogs
{
    public partial class ErrorWindow : Form
    {
        public ErrorWindow()
        {
            InitializeComponent();
            //this.ShowInTaskbar = false;
            this.Load += (object sender, EventArgs e) =>
            {
                this.Top = 50;
                this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width*2;
            };
        }
        public void LoadExc(Exception exc, string str)
        {
            msgTxt.Text = dataTxt.Text = srcTxt.Text = stackTraceTxt.Text = targetSiteTxt.Text = toStrTxt.Text = "";
            msgTxt.Text = str;

            if (exc != null)
            {
                msgTxt.Text += "\r\n" + exc.Message;
                foreach (DictionaryEntry de in exc.Data)
                    dataTxt.Text += de.Key.ToString() + "=" + de.Value.ToString() + "\n\r";

                srcTxt.Text = exc.Source;
                stackTraceTxt.Text = exc.StackTrace;
                targetSiteTxt.Text = exc.TargetSite.Name;
                toStrTxt.Text = exc.ToString();
            }
        }

        private void ErrorWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
        }

        private void ErrorWindow_Resize(object sender, EventArgs e)
        {
            panel1.Width = this.ClientSize.Width / 2;
            msgTxt.Width = srcTxt.Width = stackTraceTxt.Width = targetSiteTxt.Width = panel1.Width-10;
            msgTxt.Top = msgTxt.Left = srcTxt.Left = stackTraceTxt.Left = targetSiteTxt.Left = 2;
            msgTxt.Height = srcTxt.Height = stackTraceTxt.Height = targetSiteTxt.Height = panel1.Height / 4 - 2;
            srcTxt.Top = panel1.Height / 4 + 4;
            stackTraceTxt.Top = panel1.Height / 4 * 2 + 6;
            targetSiteTxt.Top = panel1.Height / 4 * 3 + 8;
            targetSiteTxt.Height -= 20;
        }

        private void ErrorWindow_Load(object sender, EventArgs e)
        {
            ErrorWindow_Resize(null, null);
        }
    }
}
