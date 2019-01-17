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
    class GEOTask
    {
        
            Point A;
            Point B;
            double Da; // дирекционный угол
            double L; // дистанция между точками
            public GEOTask(Point A, double Da, double L)
            {
                this.A = A;
                this.Da = Da;
                this.L = L;
            }
            public GEOTask(Point A, Point B)
            {
                this.A = A;
                this.B = B;
            }

            public static Point FirstTask(Point A, double Da, double L)
            {
                //Application.Run(new Plan())
                double alf = Math.PI * Da / 180;
                double l = L;                

                double dX = Math.Cos(alf) * l;
                double dY = Math.Sin(alf) * l;
                if (Da >= 90 & Da < 180)
                {
                    dX = -dX;
                }
                else if (Da >= 180 & Da < 290)
                {
                    dX = -dX;
                    dY = -dY;
                }
                else if (Da >= 270 & Da < 360)
                {
                    dY = -dY;
                }
                Point B = new Point(0, 0);
                B.x = A.x + dX;
                B.y = A.y + dY;
                
                return (B);
            }
            public static Shift SecondTask(Point A, Point B)
            {
                double dX = A.x - B.x;
                double dY = A.y - B.y;
                double alf = Math.Atan(dY / dX);
                double Dar = alf * 180 / Math.PI;
                double Da = 0;
                if (dX >= 0 & dY >= 0) Da = Dar;
                else if ((dX <= 0 & dY >= 0)) Da = 180 - Dar;
                else if ((dX <= 0 & dY <= 0)) Da = 180 + Dar;
                else if ((dX >= 0 & dY <= 0)) Da = 180 + Dar;

                double L = Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2));

                Shift S = new Shift(0, 0);
                S.d = Da;
                S.l = L;
                return (S);
            }

    }
}
