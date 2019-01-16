using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoTask
{
    public partial class Plan : Form
    {
        Point A;
        public Plan()
        {
            InitializeComponent();            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            base.OnPaint(e);
            A = Functions(PointA.A);
            graphics.DrawEllipse(Pens.Red, new Rectangle(1,1,10,10));
        }
    }
}
