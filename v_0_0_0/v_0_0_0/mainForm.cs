using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TALibrary;
namespace v_0_0_0
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            pages = new List<mainControl>();
        }
        public List<mainControl> pages;
        loginControl lc;
        int crt_index = 0;
        public mainControl CurrentControl
        {
            get { return pages[crt_index]; }
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            lc = new loginControl();
            mainPanel.Controls.Add(lc);
            lc.Left = mainPanel.Width / 2 - lc.Width / 2;
            lc.Top = mainPanel.Height / 2 - lc.Height / 2;
            pages.Add(lc);
            refreshPNButtons();
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            if (crt_index > 0)
            {
                pages[crt_index--].THide();
                pages[crt_index].TShow();
                if (crt_index == 1)
                {
                    //PrevBtn.Text = "Log out";
                    PrevBtn.BackgroundImage = v_0_0_0.Properties.Resources.logout;
                }
                else
                    PrevBtn.BackgroundImage = v_0_0_0.Properties.Resources.previous1;
            }
            else
                MessageBox.Show("Can't do this!");
            refreshPNButtons();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (crt_index < pages.Count - 1)
            {
                pages[crt_index++].THide();
                pages[crt_index].TShow();
            }
            else
                MessageBox.Show("Can't do this!");
            refreshPNButtons();
        }
        public void addControl(mainControl mc)
        {
            extM.Log(null, crt_index.ToString() + "\r\n" + pages.Count.ToString());
            while (pages.Count > crt_index + 1 && pages.Count > 0)
            {
                pages[pages.Count - 1].Dispose();
                pages.RemoveAt(pages.Count - 1);
                extM.Log(null, "Removed #" + pages.Count.ToString());
            }
            mc.Location = new Point(0, 0);
            pages.Add(mc);
            mainPanel.Controls.Add(mc);
            pages[crt_index].THide();
            crt_index++;
            pages[crt_index].TShow();
            if (crt_index > 1)
            {
                //PrevBtn.Text = "Back";
                PrevBtn.BackgroundImage = v_0_0_0.Properties.Resources.previous1;
            }
            else
                PrevBtn.BackgroundImage = v_0_0_0.Properties.Resources.logout;
            refreshPNButtons();
        }
        void refreshPNButtons()
        {
            PrevBtn.Visible = crt_index != 0;
            nextBtn.Enabled = crt_index < pages.Count - 1;
            mainPanel.Width++;
            mainPanel.Width--;
        }
    }
}
