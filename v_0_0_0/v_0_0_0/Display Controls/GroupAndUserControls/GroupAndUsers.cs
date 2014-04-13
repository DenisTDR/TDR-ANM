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
    public partial class GroupAndUsers : mainControl
    {
        public GroupAndUsers(Group g)
        {
            Group = g;
            InitializeComponent();
            this.Load += GroupControlEdit_Load;
            extM.mf.Resize += mf_Resize;

        }

        void mf_Resize(object sender, EventArgs e)
        {
            this.Left = extM.mf.Width / 2 - this.Width / 2;
            this.Top = extM.mf.Height / 2 - this.Height / 2;
        }
        void GroupControlEdit_Load(object sender, EventArgs e)
        {
            mf_Resize(null, null);
        }
        Group Group { get; set; }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            extM.mf.PrevBtn.PerformClick();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            
        }


        private void GroupAndUsers_Load(object sender, EventArgs e)
        {
            Reload();
        }
        List<Account> inGroupUsers, noGroupUsers;
        public void Reload()
        {
            inGroupUsers = new List<Account>();
            noGroupUsers = new List<Account>();
            label1.Text = Group.Name;
            List<List<object>> llo = ext.tconn.Get("SELECT id, name, group_id from account;", null);
            for (int i = 0; i < llo.Count; i++)
            {
                Account acc = new Account()
                {
                    Id = Convert.ToInt32(llo[i][0]),
                    Name = llo[i][1] as string,
                    Group = Convert.ToInt32(llo[i][2])
                };
                if (acc.Group == Group.ID)
                    inGroupUsers.Add(acc);
                else
                    if (acc.Group == 0)
                        noGroupUsers.Add(acc);
            }
            foreach (Account acc in inGroupUsers)
                thisGroupUsersLB.Items.Add(acc.Name);
            foreach (Account acc in noGroupUsers)
                noGroupUsersLb.Items.Add(acc.Name);


        }

        private void addTheUsersBtn_Click(object sender, EventArgs e)
        {
            List<Account> inds = fromListBox(noGroupUsersLb, noGroupUsers);
            foreach (Account acc in inds)
                addUserToThisGroup(acc);
        }
        void addUserToThisGroup(Account acc)
        {
            int y = ext.tconn.NonQuery("UPDATE account set group_id=?? where id=??;", new List<object>() { Group.ID, acc.Id });
            if (y != 1)
            {
                MessageBox.Show("An error ocurred!");
                return;
            }

            noGroupUsersLb.Items.Remove(acc.Name);
            noGroupUsers.Remove(acc);
            thisGroupUsersLB.Items.Add(acc.Name);
            inGroupUsers.Add(acc);
        }
        public List<Account> fromListBox(ListBox lb, List<Account> la)
        {
            List<Account> ret = new List<Account>();
            foreach (int x in lb.SelectedIndices)
                ret.Add(la[x]);
            return ret;
        }
        private void deleteTheUsersBtn_Click(object sender, EventArgs e)
        {
            List<Account> inds = fromListBox(thisGroupUsersLB, inGroupUsers);
            foreach (Account acc in inds)
                removeUserFromThisGroup(acc);
        }
        void removeUserFromThisGroup(Account acc)
        {
            int y = ext.tconn.NonQuery("UPDATE account set group_id=?? where id=??;", new List<object>() { 0, acc.Id });
            if (y != 1)
            {
                MessageBox.Show("An error ocurred!");
                return;
            }

            thisGroupUsersLB.Items.Remove(acc.Name);
            inGroupUsers.Remove(acc);
            noGroupUsersLb.Items.Add(acc.Name);
            noGroupUsers.Add(acc);

        }
        
    }
}
