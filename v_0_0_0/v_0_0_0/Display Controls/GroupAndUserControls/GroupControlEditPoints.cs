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
    public partial class GroupControlEditPoints : mainControl
    {
        public GroupControlEditPoints(Group g)
        {
            Group = g;
            InitializeComponent();
            extM.mf.Resize += mf_Resize;
        }

        void mf_Resize(object sender, EventArgs e)
        {
            this.Left = extM.mf.mainPanel.Width / 2 - this.Width / 2;
            this.Top = extM.mf.mainPanel.Height / 2 - this.Height / 2;
        }
        public Group Group { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            int pts=Convert.ToInt32(numericUpDown1.Value);
            int x = ext.tconn.NonQuery("UPDATE `group` set initial_points=?? where id=??;", new List<object>() { pts, Group.ID });
            int y = ext.tconn.NonQuery("UPDATE `account` set points=?? where group_id=??;", new List<object>() { pts, Group.ID });
            if (x == 1)
                MessageBox.Show("Group updated!");
            else
                MessageBox.Show("An error ocurred!");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            button1.Enabled = Convert.ToInt32(numericUpDown1.Value) != Group.InitialPoints;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            extM.mf.PrevBtn.PerformClick();
        }

        private void GroupControlEditPoints_Load(object sender, EventArgs e)
        {
            label1.Text = "How many points do you want members of " + Group.Name + " to have?";
            numericUpDown1.Value = Group.InitialPoints;
            mf_Resize(null, null);
        }
    }
}
