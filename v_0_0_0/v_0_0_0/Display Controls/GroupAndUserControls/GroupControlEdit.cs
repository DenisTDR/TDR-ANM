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
    public partial class GroupControlEdit : mainControl
    {
        public GroupControlEdit(Group g)
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
            nameTxt.Text = Group.Name;
            mf_Resize(null, null);
        }
        Group Group { get; set; }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            extM.mf.PrevBtn.PerformClick();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string s = nameTxt.Text;
            int x = ext.tconn.NonQuery("UPDATE `group` set name=?? where id=??;",
                new List<object>() { s, Group.ID });
            if (x == 1)
            {
                MessageBox.Show("The group was successfully edited!");
                cancelBtn.PerformClick();
            }
            else
            {
                MessageBox.Show("An error occurred!\r\nPlease try again!");
            }
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            okBtn.Enabled = (nameTxt.Text.Length >= 2 && nameTxt.Text != Group.Name);
        }


        
    }
}
