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
    public partial class AdminMainMenuControl : mainControl
    {
        public AdminMainMenuControl()
        {
            InitializeComponent();
            extM.mf.Resize += mf_Resize;
            this.Load += AdminMainMenuControl_Load;
        }

        void AdminMainMenuControl_Load(object sender, EventArgs e)
        {
            mf_Resize(null, null);
        }

        void mf_Resize(object sender, EventArgs e)
        {
            this.Left = extM.mf.mainPanel.Width / 2 - this.Width / 2;
            this.Top = extM.mf.mainPanel.Height / 2 - this.Height / 2;
        }

        private void groupsBtn_Click(object sender, EventArgs e)
        {
            extM.mf.addControl(new GroupsContainer());
        }

        private void categoriesBtn_Click(object sender, EventArgs e)
        {
            extM.mf.addControl(new CategoriesContainer());
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            extM.mf.addControl(new UsersContainer());
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {

        }

        private void graphBtn_Click(object sender, EventArgs e)
        {
            extM.mf.addControl(new graphControl());
        }

        
    }
}
