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
    public partial class ProductControlNew : mainControl
    {
        public ProductControlNew(Category c)
        {
            InitializeComponent();
            extM.mf.Resize += mf_Resize;
            Category = c;
        }
        Category Category;
        void mf_Resize(object sender, EventArgs e)
        {
            this.Left = extM.mf.Width / 2 - this.Width / 2;
            this.Top = extM.mf.Height / 2 - this.Height / 2;
        }
        List<Category> lc;
        private void ProductControlEditable_Load(object sender, EventArgs e)
        {
            lc = new List<Category>();
            List<List<object>> llo = ext.tconn.Get("SELECT id, name from category;", null);
            int x=0;
            for (int i = 0; i < llo.Count; i++)
            {
                lc.Add(new Category() { ID = Convert.ToInt32(llo[i][0]), Name = llo[i][1] as string });
                if (lc[i].ID == Category.ID)
                    x = i;
            }
            foreach (Category cat in lc)
                categoryCB.Items.Add(cat.Name);
            mf_Resize(null, null);
            categoryCB.SelectedIndex = x;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name; double price; int catId;
            try
            {
                name = nameTxt.Text;
                catId = lc[categoryCB.SelectedIndex].ID;
                price = Convert.ToDouble(priceTxt.Text);
                try
                {
                    int x = ext.tconn.NonQuery("insert into product (name, price, `category`) values(??, ??, ??);",
                        new List<object>() { name, price, catId });
                    MessageBox.Show("Product created!");
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
            string name; double price; int catId;
            try
            {
                name = nameTxt.Text;
                price = Convert.ToDouble(priceTxt.Text.Length > 0 ? priceTxt.Text : "0");
                catId = categoryCB.SelectedIndex;
                saveBtn.Enabled = (name.Length >= 2) && (catId >= 0 && catId < categoryCB.Items.Count);
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

        private void categoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name; double price; int catId;
            try
            {
                name = nameTxt.Text;
                price = Convert.ToDouble(priceTxt.Text.Length > 0 ? priceTxt.Text : "0");
                catId = categoryCB.SelectedIndex;
                saveBtn.Enabled = (name.Length >= 2) && (catId >= 0 && catId < categoryCB.Items.Count);
            }
            catch (Exception exc)
            {
                saveBtn.Enabled = false;
                extM.Log(exc, "textchanged editable product error!");
            }
        }
    }
}
