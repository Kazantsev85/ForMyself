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
    public partial class GeoTasks : Form
    {
        
        public GeoTasks()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double d = double.Parse(textBox3.Text);
            double l = double.Parse(textBox4.Text);
            Point B = Program.FirstTaskMenuInterface(x, y, d, l);
            textBox5.AppendText($"{B.y:f2}");
            textBox6.AppendText($"{B.x:f2}");
        }

        
    }
}
