using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TALibrary
{
    public class CustomLabel:Label
    {
        public CustomLabel()
        {
            this.ForeColor = Color.White;
            this.BackColor = Color.Transparent;
            this.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular); 
        }
    }
}
