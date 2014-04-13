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
    public partial class loginControl : mainControl
    {
        public loginControl()
        {
            InitializeComponent();
            extM.mf.Resize += mf_Resize;
        }

        public void mf_Resize(object sender, EventArgs e)
        {
            //extM.Log(null, "resized mf from login");
            this.Left = extM.mf.mainPanel.Width / 2 - this.Width / 2;
            this.Top = extM.mf.mainPanel.Height / 2 - this.Height / 2;
        }

        private void loginControl_Load(object sender, EventArgs e)
        {
            ext.initDb();
            userTxt.Text = "tdr";
            passTxt.Text = "tdr";
            //loginBtn.PerformClick();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = userTxt.Text;
            pass = passTxt.Text;
            if (ext.tconn.RowCount("SELECT count(*) from account where user=?? and password=??;",
                            new List<object>() { user, pass }) == 1)
            {
                List<object> lUser = ext.tconn.Row("Select id, user, group_id, points, admin from account where user=?? and password=??;", new List<object>() { user, pass });

                Account acc = new Account()
                {
                    Id = Convert.ToInt32(lUser[0]),
                    User = lUser[1] as string,
                    Group = Convert.ToInt32(lUser[2]),
                    Points = Convert.ToInt32(lUser[3]),
                    Admin = Convert.ToInt32(lUser[4]) == 1
                };

                ext.connectedAccount = acc;
                string msg = funcs.getSetting(acc.Admin ? "admin_welcome_message" : "welcome_message");
                extM.mf.userLbl.Text = "Logged in as: " + acc.Name + " (" + (acc.Admin ? "Admin" : "User") + ")";
                extM.mf.pointsLbl.Text = "Vote points: " + acc.Points;
                extM.mf.refreshPointsBtn.Visible = !acc.Admin;
                extM.mf.pointsLbl.Visible = !acc.Admin;
                MessageBox.Show(msg);
                if (acc.Admin)
                    extM.mf.addControl(new AdminMainMenuControl());
                else
                    extM.mf.addControl(new CategoriesContainer());

            }
            else
            {
                MessageBox.Show("Invalid User or password!");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (!ext.DbConnected)
            {
                loginBtn.Enabled = true;
                MessageBox.Show("Can't connect to DB");
            }
        }
        public override void TShow()
        {
            base.TShow();
            extM.mf.userPanel.Visible = false;
        }
        public override void THide(){
            base.THide();
            extM.mf.userPanel.Visible = true;

        }

    
    }
}