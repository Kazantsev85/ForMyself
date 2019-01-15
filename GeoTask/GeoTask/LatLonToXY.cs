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
    class LatLonToXY
    {
        
        public static void LLToXY()
        {
            Console.WriteLine("Selest the Datum: WGS84 - 1, Pulkovo42 - 2");
            int m;         
            bool flug;
            do
            {
                m = Program.InputInt();                
                flug = m == 1 | m == 2;
                if (!flug) Console.WriteLine("Error");
            } while (!flug);
            double[] el;
            if (m == 1) el = Ellipses.WGS84;
            else el = Ellipses.Pulkovo42;
            int i;
            for (i = 0; i < 2; i++) Console.WriteLine(el[i]);
            Console.ReadKey();
            
        }
    }
}
