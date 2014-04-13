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
    public partial class CategoryControlNew : mainControl
    {
        public CategoryControlNew()
        {
            InitializeComponent();
            extM.mf.Resize += mf_Resize;
            this.Load += CategoryControlNew_Load;
        }

        void CategoryControlNew_Load(object sender, EventArgs e)
        {
            mf_Resize(null, null);
        }

        void mf_Resize(object sender, EventArgs e)
        {
            this.Left = extM.mf.mainPanel.Width / 2 - this.Width / 2;
            this.Top = extM.mf.mainPanel.Height / 2 - this.Height / 2;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            extM.mf.PrevBtn.PerformClick();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string s = nameTxt.Text;

            int x = ext.tconn.NonQuery("Insert into category (name) VALUES(??);", new List<object>() { s });
            if (x == 1)
            {
                MessageBox.Show("The new category '" + s + "' was created!", "Category created!");
                cancelBtn.PerformClick();
            }
            else
                MessageBox.Show("An error occurred!\r\nPlease try again!");
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            addBtn.Enabled = nameTxt.Text.Length >= 2;
        }
    }
}
