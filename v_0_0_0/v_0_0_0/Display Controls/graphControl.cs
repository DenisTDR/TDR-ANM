using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using llo = System.Collections.Generic.List<System.Collections.Generic.List<object>>;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using ExcelLibrary;
using ExcelLibrary.SpreadSheet;
namespace TALibrary
{
    public partial class graphControl : mainControl
    {
        public graphControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        List<Category> lc;
        List<List<Product>> llp;
        List<Product> selectedProducts;
        private void graphControl_Load(object sender, EventArgs e)
        {
            Reload();
        }
        public void Reload()
        {
            copac.Nodes.Clear();
            lc = new List<Category>();
            llp = new List<List<Product>>();
            selectedProducts = new List<Product>();
            llo llo = ext.tconn.Get("SELECT id, name from category;", null);
            for (int i = 0; i < llo.Count; i++)
            {
                lc.Add(new Category() { ID = Convert.ToInt32(llo[i][0]), Name = llo[i][1] as string });
                llo llo2 = ext.tconn.Get("SELECT id, name from product where category=??;", new List<object>() { lc[i].ID });
                llp.Add(new List<Product>());
                for (int j = 0; j < llo2.Count; j++)
                {
                    Product p = new Product()
                    {
                        ID = Convert.ToInt32(llo2[j][0]),
                        Name = llo2[j][1] as string
                    };
                    llp[i].Add(p);
                }
            }
            for (int i = 0; i < lc.Count; i++)
            {
                TreeNode tn1 = new TreeNode();
                tn1.Text = lc[i].Name;
                tn1.ForeColor = Color.White;
                for (int j = 0; j < llp[i].Count; j++)
                {
                    TreeNode tn2 = new TreeNode();
                    tn2.Text = llp[i][j].Name;
                    tn2.ForeColor = Color.White;
                    tn2.Tag = llp[i][j].ID;
                    tn1.Nodes.Add(tn2);
                }
                copac.Nodes.Add(tn1);
            }

        }
        
        private void copac_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var hitTest = (sender as TreeView).HitTest(e.Location);
            if (hitTest.Location == TreeViewHitTestLocations.PlusMinus)
                return;
            if (e.Node.ForeColor == Color.White)
                e.Node.ForeColor = Color.Orange;
            else
                e.Node.ForeColor = Color.White;
            if (copac.Nodes.Contains(e.Node))
                foreach (TreeNode tn in e.Node.Nodes)
                    tn.ForeColor = e.Node.ForeColor;
        }

        private void selectAllBtn_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in copac.Nodes)
            {
                tn.ForeColor = Color.Orange;
                foreach (TreeNode tn2 in tn.Nodes)
                    tn2.ForeColor = Color.Orange;
            }
        }

        private void selectNoneBtn_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in copac.Nodes)
            {
                tn.ForeColor = Color.White;
                foreach (TreeNode tn2 in tn.Nodes)
                    tn2.ForeColor = Color.White;
            }
        }
        List<DateTime> allDates = new List<DateTime>();
        List<List<int>> Matrix;
        List<int> lPoints = new List<int>();
        void makeMatrix()
        {
            selectedProducts = new List<Product>();
            for (int i = 0; i < llp.Count; i++)
                for (int j = 0; j < llp[i].Count; j++)
                    if (copac.Nodes[i].Nodes[j].ForeColor == Color.Orange)
                        selectedProducts.Add(llp[i][j]);
            List<object> allDatesO = ext.tconn.Column("SELECT time from votes order by time asc;", null);
            allDates.Clear();

            allDates.Add((DateTime)allDatesO[0]);

            foreach (object o in allDatesO)
                if (!sameMonth((DateTime)o, allDates[allDates.Count - 1]))
                    allDates.Add((DateTime)o);

            allDatesO.Clear();

            Matrix = new List<List<int>>();
            for (int i = 0; i < selectedProducts.Count; i++)
            {
                Matrix.Add(new List<int>());
                for (int j = 0; j < allDates.Count; j++)
                    Matrix[i].Add(0);
            }
            llo llo;
            for (int pIndex = 0; pIndex < selectedProducts.Count; pIndex++)
            {
                Product crtProd = selectedProducts[pIndex];
                llo = ext.tconn.Get("SELECT time, points from votes where product_id=?? order by time asc;",
                                    new List<object>() { crtProd.ID });

                for (int i = 0; i < llo.Count; i++)
                    for (int j = 0; j < allDates.Count; j++)
                        if (sameMonth((DateTime)llo[i][0], allDates[j]))
                            Matrix[pIndex][j] += Convert.ToInt32(llo[i][1]);
            }
            for (int i = 0; i < selectedProducts.Count; i++)
                for (int j = 0; j < allDates.Count; j++)
                    if (!lPoints.Contains(Matrix[i][j]))
                        lPoints.Add(Matrix[i][j]);
        }
        void writeXls()
        {
            makeMatrix();
            Workbook wb = new Workbook();
            Worksheet ws = new Worksheet("Report");
            for (int i = 0; i < selectedProducts.Count; i++)
                ws.Cells[i + 1, 0] = new Cell(selectedProducts[i].Name);
            for (int i = 0; i < allDates.Count; i++)
                ws.Cells[0, i + 1] = new Cell(allDates[i].Month.ToString() + "/" + allDates[i].Year.ToString());

            //extM.Log(null, "allDate.Count: " + allDates.Count.ToString());

            for (int i = 0; i < selectedProducts.Count; i++)
                for (int j = 0; j < allDates.Count; j++)
                    ws.Cells[i + 1, j + 1] = new Cell(Matrix[i][j]);
            wb.Worksheets.Add(ws);
            wb.Save("report.xls");
        }
        private void drawBtn_Click(object sender, EventArgs e)
        {

            Pen pen1=new Pen(Color.Black, 3);
            Pen pen2=new Pen(Color.Red, 3);
            

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            makeMatrix();
            pictureBox1.Image = bmp;
            if (selectedProducts.Count == 0)
                return;
            int sMax=0;
           
            for (int i = 0; i < selectedProducts.Count; i++)
                for (int j = 0; j < allDates.Count; j++)
                    sMax = Math.Max(sMax, Matrix[i][j]);
            
            int gl = allDates.Count;
            int width = bmp.Width - 100;
            int height = bmp.Height - 100;
            double monthLength = (double)width / (double)(gl - 1);
            double pointLength = (double)height / (double)sMax;

            extM.Log(null, "selectedProducts.Count: " + selectedProducts.Count.ToString());
            extM.Log(null, "gl: " + gl.ToString());

            for (int pIndex = 0; pIndex < selectedProducts.Count; pIndex++)
            {
                pen2 = new Pen(RandomColor(), 3);
                for (int i = 1; i < gl; i++)
                {

                    Point p1 = new Point(i - 1, Matrix[pIndex][i - 1]);
                    Point p2 = new Point(i, Matrix[pIndex][i]);

                    extM.Log(null, "dr: " + p1.ToString() + "  ->>>  " + p2.ToString());

                    p1.X = (int)(p1.X * monthLength);
                    p1.Y = (int)(p1.Y * pointLength);
                    p2.X = (int)(p2.X * monthLength);
                    p2.Y = (int)(p2.Y * pointLength);

                    p1.X += 50;
                    p1.Y -= 50;
                    p2.X += 50;
                    p2.Y -= 50;

                    p1.Y = height - p1.Y;
                    p2.Y = height - p2.Y;

                    g.DrawLine(pen2, p1, p2);
                }
            }
            g.DrawLine(pen1, new Point(50, height + 75), new Point(50, 50)); //oy
            g.DrawLine(pen1, new Point(25, height + 50), new Point(width + 50, height + 50)); //ox

            for (int i = 0; i < gl; i++)
                g.DrawLine(pen1, new Point((int)(i * monthLength)+50, height + 50 - 5),
                                new Point((int)(i * monthLength)+50, height + 50 + 5));
            for (int i = 0; i < lPoints.Count; i++)
                g.DrawLine(pen1, new Point(50 - 5, height - (int)(lPoints[i] * pointLength)+50),
                    new Point(50 + 5, height - (int)(lPoints[i] * pointLength)+50));

            //g.DrawRectangle(new Pen(new SolidBrush(Color.Red), 3), new Rectangle(0, 0, bmp.Width, bmp.Height));
            pictureBox1.Image = bmp;
        }
        Random r = new Random(DateTime.Now.Millisecond);



        public Color RandomColor()
        {
            byte red = (byte)r.Next(0, 255);
            byte green = (byte)r.Next(0, 255);
            byte blue = (byte)r.Next(0, 255);
            return Color.FromArgb(red, green, blue);

        }
        public bool sameMonth(DateTime dt1, DateTime dt2)
        {
            return dt1.Month == dt2.Month && dt1.Year == dt2.Year;
        }

        private void exportXlsBtn_Click(object sender, EventArgs e)
        {
            writeXls();
            extM.mf.addControl(new tableControl(Matrix, allDates, selectedProducts));
        }
    }
    public class TimePoint
    {
        public TimePoint() { }
        public DateTime DateTime;
        public int Points;
    }
}
