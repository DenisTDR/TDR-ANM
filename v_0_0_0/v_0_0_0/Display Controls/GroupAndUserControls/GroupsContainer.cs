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
    public partial class GroupsContainer : mainControl
    {
        public GroupsContainer()
        {
            InitializeComponent();
            this.Load += GroupsContainer_Load;
            extM.mf.Resize += mf_Resize;
        }

        void mf_Resize(object sender, EventArgs e)
        {
            this.Size = extM.mf.mainPanel.Size;
            foreach (Control c in this.Controls)
                if (c.GetType() == typeof(GroupControl))
                    c.Left = this.Width / 2 - c.Width / 2;

            refreshBtn.Left = this.Width - refreshBtn.Width - 20;
            addUserBtn.Left = refreshBtn.Left - addUserBtn.Width - 5;
        }

        void GroupsContainer_Load(object sender, EventArgs e)
        {
            Reload();
            mf_Resize(null, null);
        }
        public void Reload()
        {
            List<List<object>> llo = ext.tconn.Get("SELECT id, name, initial_points from `group`;", null);
            this.Controls.Clear();
            this.Controls.Add(addUserBtn);
            this.Controls.Add(refreshBtn);
            int y = 5;
            for (int i = 0; i < llo.Count; i++)
            {
                Group g = new Group() { ID = Convert.ToInt32(llo[i][0]), Name = llo[i][1] as string, InitialPoints = Convert.ToInt32(llo[i][2]) };
                GroupControl gc = new GroupControl(g);
                gc.Left = this.Width / 2 - gc.Width / 2;
                gc.Top = y;
                this.Controls.Add(gc);
                y += gc.Height + 5;
            }

        }
        public override void TShow()
        {
            base.TShow();
            Reload();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            extM.mf.addControl(new GroupControlNew());
        }
    }
}
