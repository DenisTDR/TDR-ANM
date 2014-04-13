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
    public partial class ProductControlVote : mainControl
    {
        public ProductControlVote(Product p)
        {
            Product = p;
            InitializeComponent();
            extM.mf.Resize += mf_Resize;
            this.Load += CategoryControlNew_Load;
        }
        Product Product { get; set; }
        void CategoryControlNew_Load(object sender, EventArgs e)
        {
            mf_Resize(null, null);
            label1.Text = "How many points do you want to spend on " + Product.Name + "?";
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
            int points = Convert.ToInt32(pointsNr.Value);

            int x = ext.tconn.NonQuery("Update product set vote_points=vote_points+?? where id=??;",
                new List<object>() { points, Product.ID });
            int y = ext.tconn.NonQuery("INSERT into votes (product_id, points, account_id, time) VALUES(??, ??, ??, CURRENT_TIMESTAMP);",
                new List<object>() { Product.ID, points, ext.connectedAccount.Id });
            int z = ext.tconn.NonQuery("UPDATE account set points=points-?? where id=??;",
                new List<object>() { points, ext.connectedAccount.Id});

            if (x == 1 && y == 1 && z == 1)
            {
                ext.connectedAccount.Points -= points;
                MessageBox.Show("Your vote was registered.\r\nThank you!", "Success!");
                cancelBtn.PerformClick();
            }
            else
            {
                MessageBox.Show("An error occurred!\r\nPlease try again!");
                extM.Log(null, "vote error " + x.ToString() + " " + y.ToString() + " " + z.ToString());
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        public override void TShow()
        {
            base.TShow();
            pointsNr.Minimum = 1;
            pointsNr.Maximum = ext.connectedAccount.Points;
        }

    }
}
