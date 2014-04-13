using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using v_0_0_0;
namespace TALibrary
{
    public partial class CategoriesContainer : mainControl
    {
        public CategoriesContainer()
        {
            InitializeComponent();
            extM.mf.Resize += mf_Resize;
            this.Resize += CategoriesContainer_Resize;
            refreshBtn.Left = this.Width - refreshBtn.Width - 5;
            this.Dock = DockStyle.Fill;
        }

        void CategoriesContainer_Resize(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
                if (c as CategoryControl != null)
                    c.Left = this.Width / 2 - c.Width / 2;
            refreshBtn.Left = this.Width - refreshBtn.Width - 5;
            addBtn.Top = this.Height / 2 - addBtn.Height / 2;
        }

        void mf_Resize(object sender, EventArgs e)
        {

        }

        private void categoryContainer_Load(object sender, EventArgs e)
        {
            Reload();
            mf_Resize(null, null);
        }
        public void Reload()
        {
            this.Visible = false;
            ext.initDb();
            List<List<object>> llo = ext.tconn.Get("SELECT * from category order by name asc;", null);
            if (extM.categories == null)
                extM.categories = new List<Category>();
            extM.categories.Clear();
            this.Controls.Clear();
            this.Controls.Add(refreshBtn);
            this.Controls.Add(addBtn);
            int y = 10;
            for (int i = 0; i < llo.Count; i++)
            {
                Category c = new Category()
                {
                    ID = Convert.ToInt32(llo[i][0]),
                    Name = llo[i][1] as string
                };
                extM.categories.Add(c);

                CategoryControl cc = new CategoryControl()
                {
                    Category = c
                };
                cc.Left = this.Width / 2 - cc.Width / 2;
                cc.Top = y;
                this.Controls.Add(cc);
                y += cc.Height + 5;
            }
            addBtn.Visible = ext.connectedAccount.Admin;
            this.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            extM.mf.addControl(new CategoryControlNew());
        }
        public override void TShow()
        {
            base.TShow();
            Reload();
        }
    }
}
