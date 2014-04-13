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
    public partial class ProductControl : UserControl
    {
        public ProductControl(Product _p)
        {
            this.Product = _p;
            InitializeComponent();
            deleteBtn.Visible = editBtn.Visible = ext.connectedAccount.Admin;
            voteBtn.Visible = !ext.connectedAccount.Admin;
        }
        Product Product { get; set; }


        private void ProductControl_Load(object sender, EventArgs e)
        {
            pNameLbl.Text = Product.Name;
            if (ext.connectedAccount.Points == 0)
                voteBtn.Enabled = false;
        }

        private void voteBtn_Click(object sender, EventArgs e)
        {
            extM.mf.addControl(new ProductControlVote(Product));
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this product?", "Are you sure?", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            int x = ext.tconn.NonQuery("DELETE from product where id=??;", new List<object>() { Product.ID });
            if (x != 1)
                MessageBox.Show("The product couldn't be deleted!\r\nPlease try again.", "An error occurred!");
            else
            {
                ext.tconn.NonQuery("DELETE from votes where product_id=??;", new List<object>() { Product.ID });
                extM.mf.CurrentControl.TShow();
            }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            extM.mf.addControl(new ProductControlEdit(Product));
        }
    }
}
