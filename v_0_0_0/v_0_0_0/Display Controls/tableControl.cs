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
    public partial class tableControl : mainControl
    {
        public tableControl(List<List<int>> m, List<DateTime> ldt, List<Product> lp)
        {
            this.Dock = DockStyle.Fill;
            Matrix=m;
            allDates = ldt;
            SelectedProducts = lp;
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("--", typeof(string)));
            //dgv.Columns.Add(new DataGridViewColumn(typeof(string)));
            //dgv.Columns[0].HeaderText = "";
            for (int i = 0; i < ldt.Count; i++)
                dt.Columns.Add(new DataColumn(ldt[i].Month.ToString() + "/" + ldt[i].Year.ToString(), typeof(int)));
            for (int i = 0; i < SelectedProducts.Count; i++)
                dt.Rows.Add(SelectedProducts[i].Name);
            for (int j = 0; j < SelectedProducts.Count; j++)
                for (int i = 0; i < ldt.Count; i++)
                {
                    dt.Rows[j].SetField(i+1, Matrix[j][i]);
                }
            dgv.DataSource = dt;
        }
        List<List<int>> Matrix;
        List<DateTime> allDates;
        List<Product> SelectedProducts;
        
    }
}
