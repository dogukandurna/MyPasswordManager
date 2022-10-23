using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPM
{
    class ExPanel : Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorButtom { get; set; }
        public Color Colorleft { get; set; }
        public Color colorright { get; set; }
        public float Angle { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle,this.Colorleft,this.colorright,this.Angle);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
