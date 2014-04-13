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
    public partial class UsersContainer : mainControl
    {
        public UsersContainer()
        {
            InitializeComponent();
            extM.mf.Resize += mf_Resize;
            this.Load += GroupControlNew_Load;
            this.Top = this.Left = 0;
        }

        void GroupControlNew_Load(object sender, EventArgs e)
        {
            mf_Resize(null, null);
        }

        void mf_Resize(object sender, EventArgs e)
        {
            this.Size = extM.mf.mainPanel.Size;
            int y = 5;
            foreach (Control uct in panel2.Controls)
            {
                uct.Left = panel2.Width / 2 - uct.Width / 2;
                uct.Top = y;
                y += uct.Height + 5;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            extM.mf.PrevBtn.PerformClick();
        }

        List<Group> lg;
        private void UserControlNew_Load(object sender, EventArgs e)
        {
            lg = new List<Group>();
            lg.Add(new Group() { ID = -1, Name = "All Users" });
            lg.Add(new Group() { ID = 0, Name = "No Group" });
            List<List<object>> llo = ext.tconn.Get("SELECT id, name from `group`;", null);
            for (int i = 0; i < llo.Count; i++)
                lg.Add(new Group() { ID = Convert.ToInt32(llo[i][0]), Name = llo[i][1] as string });
            groupLB.Items.Clear();
            foreach (Group g in lg)
                groupLB.Items.Add(g.Name);

        }

        private void groupLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reload();
        }
        public void Reload()
        {
            int y =  5;
            int x = groupLB.SelectedIndex;
            if (x < 0 || x >= groupLB.Items.Count)
                return;
            Group g = lg[x];
            panel2.Controls.Clear();
            List<List<object>> llo;
            if (g.ID == -1)
                llo = ext.tconn.Get("SELECT id, name, points, group_id, user from account where admin=0;", null);
            else
                llo = ext.tconn.Get("SELECT id, name, points, group_id, user from account where group_id=?? and admin=0;", new List<object>() { g.ID });
            extM.Log(null, llo.Count.ToString());
            for (int i = 0; i < llo.Count; i++)
            {
                Account acc = new Account()
                {
                    Id = Convert.ToInt32(llo[i][0]),
                    Name = llo[i][1] as string,
                    Points = Convert.ToInt32(llo[i][2]),
                    Group = Convert.ToInt32(llo[i][3]),
                    User=llo[i][4] as string
                };
                UserControlT uct = new UserControlT(acc);
                uct.Left = panel2.Width / 2 - uct.Width / 2;
                uct.Top = y;
                y += uct.Height + 5;
                panel2.Controls.Add(uct);
            }
        }
        public override void TShow()
        {
            base.TShow();
            Reload();
        }

        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            extM.mf.PrevBtn.PerformClick();
        }

        private void newUserBtn_Click(object sender, EventArgs e)
        {
            extM.mf.addControl(new UserControlNew());
        }

    }
}
