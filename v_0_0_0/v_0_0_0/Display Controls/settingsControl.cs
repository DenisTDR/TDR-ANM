using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TALibrary
{
    public partial class settingsControl : mainControl
    {
        public settingsControl()
        {
            InitializeComponent();
            extM.mf.Resize += mf_Resize;
            this.Load += settingsControl_Load;
        }

        void settingsControl_Load(object sender, EventArgs e)
        {
            customTextBox1.Text = funcs.getSetting("welcome_message");
            customTextBox2.Text = funcs.getSetting("admin_welcome_message");

        }

        public void mf_Resize(object sender, EventArgs e)
        {
            //extM.Log(null, "resized mf from login");
            this.Left = extM.mf.mainPanel.Width / 2 - this.Width / 2;
            this.Top = extM.mf.mainPanel.Height / 2 - this.Height / 2;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            string s = customTextBox1.Text;
            string s2 = customTextBox2.Text;
            ext.tconn.NonQuery("UPDATE setting set value=?? where `key`='welcome_message';",
                new List<object>() { s });
            ext.tconn.NonQuery("UPDATE setting set value=?? where `key`='admin_welcome_message';",
                new List<object>() { s2 });
            customButton2.PerformClick();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            extM.mf.PrevBtn.PerformClick();
        }

        
    }
}
