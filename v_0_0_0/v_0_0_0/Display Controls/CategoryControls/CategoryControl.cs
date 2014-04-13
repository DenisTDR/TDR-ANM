using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TALibrary;
namespace TALibrary
{
    public partial class CategoryControl : mainControl
    {
        public CategoryControl()
        {
            InitializeComponent();
            catEditBtn.Visible = catDeleteBtn.Visible = ext.connectedAccount.Admin;
        }
        Category cat;
        public Category Category
        {
            get { return cat; }
            set { cat = value; catBtn.Text = cat.Name; }
        }

        private void catBtn_Click(object sender, EventArgs e)
        {
            extM.mf.addControl(new ProductsContainer(cat));
        }

        private void catDeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this category?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ext.tconn.NonQuery("DELETE from category where id=??;", new List<object>() { cat.ID });
                (this.Parent as CategoriesContainer).Reload();               
            }
        }

        private void catEditBtn_Click(object sender, EventArgs e)
        {
            extM.mf.addControl(new CategoryControlEdit(this.Category));
        }
    }
}
