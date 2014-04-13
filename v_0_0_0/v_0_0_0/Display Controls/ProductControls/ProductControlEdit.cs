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
    public partial class ProductControlEdit : mainControl
    {
        public ProductControlEdit(Product p)
        {
            Product = p;
            InitializeComponent();
            extM.mf.Resize += mf_Resize;
        }

        void mf_Resize(object sender, EventArgs e)
        {
            this.Left = extM.mf.Width / 2 - this.Width / 2;
            this.Top = extM.mf.Height / 2 - this.Height / 2;
        }
        Product Product { get; set; }
        List<Category> lc;
        private void ProductControlEditable_Load(object sender, EventArgs e)
        {
            int x=0;
            mf_Resize(null, null);
            nameTxt.Text = Product.Name;
            priceTxt.Text = Product.Price.ToString();
            votePNr.Value = Product.VotePoints;
            lc = new List<Category>();
            List<List<object>> llo = ext.tconn.Get("SELECT id, name from category;", null);
            for (int i = 0; i < llo.Count; i++)
            {
                lc.Add(new Category() { ID = Convert.ToInt32(llo[i][0]), Name = llo[i][1] as string });
                if (lc[i].ID == Product.Category)
                    x = i;
            }
            foreach (Category cat in lc)
                categoryCB.Items.Add(cat.Name);
            categoryCB.SelectedIndex = x;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name; double price; int votePoints, catId;
            try
            {
                name = nameTxt.Text;
                price = Convert.ToDouble(priceTxt.Text);
                votePoints = Convert.ToInt32(votePNr.Value);
                catId = lc[categoryCB.SelectedIndex].ID;
                try
                {
                    int x = ext.tconn.NonQuery("UPDATE product set name=??, price=??, vote_points=??, category=?? where id=??;",
                        new List<object>() { name, price, votePoints, catId,  Product.ID });
                    Product.Name = name;
                    Product.Price = price;
                    Product.VotePoints = votePoints;
                    MessageBox.Show("Product edited!");
                    cancelBtn.PerformClick();
                }
                catch (Exception exc) { extM.Log(exc, "save editable product error!"); }
            }
            catch {
                MessageBox.Show("Please recheck the fields!");
            }
        }
        private void Txt_TextChanged(object sender, EventArgs e)
        {
            string name; double price; int catId, votePoints;
            try
            {
                name = nameTxt.Text;
                price = Convert.ToDouble(priceTxt.Text.Length > 0 ? priceTxt.Text : "0");
                catId = categoryCB.SelectedIndex;
                votePoints = Convert.ToInt32(votePNr.Value);
                saveBtn.Enabled = (name.Length >= 2) && (catId >= 0 && catId < categoryCB.Items.Count);
                catId = lc[catId].ID;
                if (saveBtn.Enabled)
                    saveBtn.Enabled = name != Product.Name || price != Product.Price || catId != Product.Category || votePoints != Product.VotePoints;
            }
            catch (Exception exc)
            {
                saveBtn.Enabled = false;
                extM.Log(exc, "textchanged editable product error!");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            extM.mf.PrevBtn.PerformClick();
        }
    }
}
