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
    public partial class UserControlT : mainControl
    {
        public UserControlT(Account ac)
        {
            Account = ac;
            InitializeComponent();
            this.Load += UserControlT_Load;

        }

        void UserControlT_Load(object sender, EventArgs e)
        {
            nameLbl.Text = Account.Name;
        }
        Account Account { get; set; }  

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            extM.mf.PrevBtn.PerformClick();
        }              

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this user?", "Are you sure?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int x = ext.tconn.NonQuery("DELETE from account where id=??;", new List<object>() { Account.Id });
                if (x != 1)
                    MessageBox.Show("The account couldn't be deleted!\r\nPlease try again.", "An error occurred!");
                else
                {
                    extM.mf.CurrentControl.TShow();
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            extM.mf.addControl(new UserControlEdit(Account));
        }
        
    }
}
