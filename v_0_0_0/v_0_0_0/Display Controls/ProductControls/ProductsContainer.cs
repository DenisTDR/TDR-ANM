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
    public partial class ProductsContainer : mainControl
    {
        public ProductsContainer(Category c)
        {
            this.Category = c;
            InitializeComponent();
            this.Resize += categoriesContainer_Resize;
            extM.mf.Resize += mf_Resize;
        }
        void mf_Resize(object sender, EventArgs e)
        {
            this.Size = extM.mf.mainPanel.Size;
        }

        void categoriesContainer_Resize(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
                c.Left = this.Width / 2 - c.Width / 2;
            refreshBtn.Left = this.Width - refreshBtn.Width - 5;
            addUserBtn.Left = refreshBtn.Left - addUserBtn.Width - 5;
        }

        public Category Category;

        private void ProductsContainer_Load_1(object sender, EventArgs e)
        {
            Reload();
        }
        public void Reload()
        {
            int y = 10;
            ext.initDb();
            List<List<object>> llo = ext.tconn.Get("SELECT id, name, vote_points, category, price from product where category=??", new List<object>() { Category.ID });
            this.Controls.Clear();
            this.Controls.Add(addUserBtn);
            this.Controls.Add(refreshBtn);
            for (int i = 0; i < llo.Count; i++)
            {
                Product p = new Product()
                {
                    ID = Convert.ToInt32(llo[i][0]),
                    Name = llo[i][1].ToString(),
                    VotePoints = Convert.ToInt32(llo[i][2]),
                    Category = Convert.ToInt32(llo[i][3]),
                    Price = Convert.ToInt32(llo[i][4])
                };
                ProductControl pc = new ProductControl(p);
                pc.Left = this.Width / 2 - pc.Width / 2;
                pc.Top = y;
                y += pc.Height + 5;
                this.Controls.Add(pc);
            }
            this.Size = extM.mf.mainPanel.Size;
        }
        public override void TShow()
        {
            base.TShow();
            Reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            extM.mf.addControl(new ProductControlNew(Category));
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
