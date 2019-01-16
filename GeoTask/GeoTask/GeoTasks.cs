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
            double x;
            double y;
            double x2;
            double y2;
            double d;
            double l;
            string Easting1 = textBox1.Text;
            string Easting2 = textBox6.Text;
            string Northing1 = textBox2.Text;
            string Northing2 = textBox5.Text;
            string Direction = textBox4.Text;
            string Dist = textBox3.Text;

            bool text1 = double.TryParse(Easting1, out x);
            bool text2 = double.TryParse(Northing1, out y);
            bool text3 = double.TryParse(Dist, out l);
            bool text4 = double.TryParse(Direction, out d);
            bool text5 = double.TryParse(Northing2, out y2);
            bool text6 = double.TryParse(Easting2, out x2);

            if (!text5 & !text6)
            {
                //double x = double.Parse(textBox1.Text);
                //double y = double.Parse(textBox2.Text);
                //double d = double.Parse(textBox3.Text);
                //double l = double.Parse(textBox4.Text);
                Point B = Functions.FirstTaskMenuInterface(x, y, d, l);
                textBox5.AppendText($"{B.y:f2}");
                textBox6.AppendText($"{B.x:f2}");
            }
            if (!text3 & !text4)
            {
                Shift S = Functions.SecondTaskMenuInterface(x, y, x2, y2);
                textBox3.AppendText($"{S.l:f2}");
                textBox4.AppendText($"{S.d:f2}");
            }
            if (!text1 & !text2 &!text3 & !text4 & !text5 & !text6)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox1.AppendText("Error");
                textBox2.AppendText("Error");
                textBox3.AppendText("Error");
                textBox4.AppendText("Error");
                textBox5.AppendText("Error");
                textBox6.AppendText("Error");
            }
            if (text1 & text2 & text3 & text4 & text5 & text6)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox1.AppendText("Error");
                textBox2.AppendText("Error");
                textBox3.AppendText("Error");
                textBox4.AppendText("Error");
                textBox5.AppendText("Error");
                textBox6.AppendText("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
        //Console.WriteLine($"Дирекционный угол: {S.d:f2}; Дистанция: {S.l:f2}");

    }
}
