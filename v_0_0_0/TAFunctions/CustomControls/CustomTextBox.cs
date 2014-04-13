using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TALibrary
{
    public class CustomTextBox:TextBox
    {
        public CustomTextBox()
        {
            this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular);
            this.BackColor = Color.DimGray;
            this.ForeColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
