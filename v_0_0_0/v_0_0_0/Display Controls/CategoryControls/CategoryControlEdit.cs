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
    public partial class CategoryControlEdit : mainControl
    {
        public CategoryControlEdit(Category c)
        {
            Category = c;
            InitializeComponent();
            extM.mf.Resize += mf_Resize;
            this.Load += CategoryControlNew_Load;
        }
        Category Category { get; set; }
        void CategoryControlNew_Load(object sender, EventArgs e)
        {
            mf_Resize(null, null);
            nameTxt.Text = Category.Name;
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


        private void saveBtn_Click(object sender, EventArgs e)
        {
            string s = nameTxt.Text;
            int x = ext.tconn.NonQuery("Update category set name=?? where id=??;", new List<object>() { s, Category.ID });
            if (x == 1)
            {
                MessageBox.Show("The category name was modified!", "Category updated!");
                cancelBtn.PerformClick();
            }
            else
                MessageBox.Show("An error occurred!\r\nPlease try again!");
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = nameTxt.Text != Category.Name;
            if (saveBtn.Enabled)
                saveBtn.Enabled = nameTxt.Text.Length >= 2;
        }
    }
}
