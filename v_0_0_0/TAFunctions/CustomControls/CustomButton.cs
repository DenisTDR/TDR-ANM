using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace TALibrary
{
    public class CustomButton:Button
    {
        public CustomButton()
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 75, 75);
            this.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 85, 85);
            this.ForeColor = Color.White;
            this.Cursor = Cursors.Hand;
            this.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular); 
        }
    }
}
