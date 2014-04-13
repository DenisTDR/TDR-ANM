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
    public partial class UserControlNew : mainControl
    {
        public UserControlNew()
        {
            InitializeComponent();
            extM.mf.Resize += mf_Resize;
            this.Load += GroupControlNew_Load;
        }

        void GroupControlNew_Load(object sender, EventArgs e)
        {
            mf_Resize(null, null);
        }

        void mf_Resize(object sender, EventArgs e)
        {
            this.Left = extM.mf.Width / 2 - this.Width / 2;
            this.Top = extM.mf.Height / 2 - this.Height / 2;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            extM.mf.PrevBtn.PerformClick();
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            addBtn.Enabled = nameTxt.Text.Length >= 2;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name, username;
            int group_id = Convert.ToInt32(lg[groupCB.SelectedIndex].ID);
            name= nameTxt.Text;
            username=userNameTxt.Text;
            int x;
            x = ext.tconn.RowCount("SELECT count(*) from account where user=?? or name=??;", new List<object>() { username, name });
            if (x != 0)
            {
                MessageBox.Show("Another person is already using this name or username!");
                return;
            }
            x = ext.tconn.NonQuery("Insert into account (name, user, group_id) VALUES(??, ??, ??);", new List<object>() { name, username, group_id  });
            if (x == 1)
            {
                MessageBox.Show("The new user '" + name + "' was created!", "User created!");
                cancelBtn.PerformClick();
            }
            else
                MessageBox.Show("An error occurred!\r\nPlease try again!");
        }
        List<Group> lg;
        private void UserControlNew_Load(object sender, EventArgs e)
        {
            lg = new List<Group>();
            lg.Add(new Group() { ID = 0, Name = "No Group" });
            List<List<object>> llo = ext.tconn.Get("SELECT id, name from `group`;", null);
            for (int i = 0; i < llo.Count; i++)
                lg.Add(new Group() { ID = Convert.ToInt32(llo[i][0]), Name = llo[i][1] as string });
            
            groupCB.Items.Clear();
            foreach (Group g in lg)
                groupCB.Items.Add(g.Name);

        }

        private void groupCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}
