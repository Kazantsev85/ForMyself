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
        public Plan()
        {
            InitializeComponent();
            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            base.OnPaint(e);
            //string Easting1 = GeoTasks.textBox1.Text;
            int X1 = Convert.ToInt32(PointGraph.X1);
            int X2 = Convert.ToInt32(PointGraph.X2);
            int Y1 = Convert.ToInt32(PointGraph.Y1);
            int Y2 = Convert.ToInt32(PointGraph.Y2);
            graphics.DrawEllipse(Pens.Red, new Rectangle(X1, Y1, 10, 10));
            graphics.DrawEllipse(Pens.Green, new Rectangle(X2, Y2, 10, 10));
        }

        private void Plan_Load(object sender, EventArgs e)
        {     
            
        }
    }
}
