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
    public partial class UserControlEdit : mainControl
    {
        public UserControlEdit(Account acc)
        {
            Account = acc;
            InitializeComponent();
            extM.mf.Resize += mf_Resize;
            this.Load += GroupControlNew_Load;
        }
        Account Account;
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
            saveBtn.Enabled = nameTxt.Text.Length >= 2 && userNameTxt.Text.Length >= 2 && (groupCB.SelectedIndex >= 0 && groupCB.SelectedIndex < groupCB.Items.Count);
            if (saveBtn.Enabled)
                saveBtn.Enabled = nameTxt.Text != Account.Name ||
                                userNameTxt.Text != Account.User ||
                                lg[groupCB.SelectedIndex].ID != Account.Group;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name, username;
            int group_id = Convert.ToInt32(lg[groupCB.SelectedIndex].ID);
            name= nameTxt.Text;
            username=userNameTxt.Text;
            int x = ext.tconn.NonQuery("UPDATE account set name=??, user=??, group_id=?? where id=??;",
                new List<object>() { name, username, group_id , Account.Id});
            if (x == 1)
            {
                MessageBox.Show("User edited!");
                Account.User = username;
                Account.Name = name;
                Account.Group = group_id;
                cancelBtn.PerformClick();
            }
            else
                MessageBox.Show("An error occurred!");
        }
        List<Group> lg;
        private void UserControlNew_Load(object sender, EventArgs e)
        {
            int x=0;
            lg = new List<Group>();
            lg.Add(new Group() { ID = 0, Name = "No Group" });
            List<List<object>> llo = ext.tconn.Get("SELECT id, name from `group`;", null);
            for (int i = 0; i < llo.Count; i++)
            {
                lg.Add(new Group() { ID = Convert.ToInt32(llo[i][0]), Name = llo[i][1] as string });
                if (Account.Group == lg[i].ID)
                    x = i;
            }
            
            groupCB.Items.Clear();
            foreach (Group g in lg)
                groupCB.Items.Add(g.Name);
            groupCB.SelectedIndex = x;
            nameTxt.Text = Account.Name;
            userNameTxt.Text = Account.User;
        }

        private void groupCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = nameTxt.Text.Length >= 2 && userNameTxt.Text.Length >= 2 && (groupCB.SelectedIndex >= 0 && groupCB.SelectedIndex < groupCB.Items.Count);
            if (saveBtn.Enabled)
                saveBtn.Enabled = nameTxt.Text != Account.Name ||
                                userNameTxt.Text != Account.User ||
                                lg[groupCB.SelectedIndex].ID != Account.Group;
        }
        
    }
}
