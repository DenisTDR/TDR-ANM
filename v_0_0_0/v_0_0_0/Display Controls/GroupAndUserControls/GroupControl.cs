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
    public partial class GroupControl : mainControl
    {
        public GroupControl(Group g)
        {
            InitializeComponent();
            this.Load += GroupControl_Load;
            Group = g;
        }

        void GroupControl_Load(object sender, EventArgs e)
        {
            nameLbl.Text = Group.Name;
        }
        public Group Group { get; set; }

        private void editBtn_Click(object sender, EventArgs e)
        {
            extM.mf.addControl(new GroupControlEdit(Group));
        }

        private void editPointsBtn_Click(object sender, EventArgs e)
        {
            extM.mf.addControl(new GroupControlEditPoints(Group));
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this group?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ext.tconn.NonQuery("DELETE from `group` where id=??;", new List<object>() { Group.ID });
                ext.tconn.NonQuery("UPDATE account set group_id=0 where group_id=??;", new List<object>() { Group.ID });
                (this.Parent as GroupsContainer).Reload();
            }
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            extM.mf.addControl(new GroupAndUsers(Group));
        }

    }
}
