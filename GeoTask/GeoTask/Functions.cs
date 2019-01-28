using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoTask
{
    public class Functions
    {       

        double X1 = 0 ;
        //double L;

        //public double PointXA
        //{
        //    get { return X1; }
        //}
        //public double PointYA
        //{
        //    get { return Y1; }
        //}
        //public double PointXB
        //{
        //    get { return X2; }
        //}
        //public double PointYB
        //{
        //    get { return Y2; }
        //}

        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Выберите задачу:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Для решения прямой геодезической задачи нажите:........................1");
            Console.WriteLine("Для решения обратной геодезической задачи нажите:......................2");
            Console.WriteLine("Для пересчета географических координат в плоские прямоугольные нажмите:3");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Выход: 0");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Start()
        {
            Console.WriteLine("Геокалькулятор");
            Console.ReadKey();
            string m;
            do
            {
                Menu(); // Вызывает меню
                m = Console.ReadLine();
                switch (m)
                {
                    //case "1":
                    //    Task1();
                    //    break;
                    //case "2":
                    //    Task2();
                    //    break;
                    case "3":
                        Task3();
                        break;
                    case "0":
                        Console.WriteLine("До свидания!");
                        Console.ReadKey();
                        break;
                    default:
                        Default();
                        break;
                }
            } while (m != "0");
        }
        //static void Task1()
        //{
        //    Console.ForegroundColor = ConsoleColor.Magenta;
        //    FirstTaskMenu();
        //    Console.ReadKey();
        //}
        //static void Task2()
        //{
        //    Console.ForegroundColor = ConsoleColor.Magenta;
        //    SecondTaskMenu();
        //    Console.ReadKey();
        //}
        static void Task3()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            LatLonToXY.LLToXY();
            Console.ReadKey();
        }
        static void Default()
        {
            Console.WriteLine("Неверно!");
            Console.ReadKey();
            Console.Clear();
        }
        public static double InputDouble() // защита от дурака
        {
            double x;
            string s;
            bool flug;
            do
            {
                s = Console.ReadLine();
                flug = double.TryParse(s, out x);
                if (!flug) Console.WriteLine("Error");
            } while (!flug);
            return x;
        }
        public static int InputInt() // защита от дурака
        {
            int x;
            string s;
            bool flug;
            do
            {
                s = Console.ReadLine();
                flug = int.TryParse(s, out x);
                if (!flug) Console.WriteLine("Error");
            } while (!flug);
            return x;
        }
        static double InputDoubleAngl() // защита от дурака 
        {
            double x;
            bool flug;
            do
            {
                x = InputDouble();
                flug = x >= 0 & x < 360;
                if (!flug) Console.WriteLine("Error");
            } while (!flug);
            return x;
        }
        //static void FirstTaskMenu()
        //{
        //    Console.WriteLine("Enter Easting");
        //    double Y = InputDouble();
        //    Console.WriteLine("Enter Nothing");
        //    double X = InputDouble();
        //    Console.WriteLine("Enter Direction");
        //    double Da = InputDoubleAngl();
        //    Console.WriteLine("Enter Distance");
        //    double L = InputDouble();

        //    Point A = new Point(X, Y);
        //    Point B = GEOTask.FirstTask(A, Da, L);
        //    Console.WriteLine("Координаты второй точки:");
        //    Console.WriteLine($"Nothing: {B.x:f2}; Easting: {B.y:f2}");

        //    Console.ReadKey();
        //}
        static public Point FirstTaskMenuInterface(double x, double y, double d, double l)
        {
            double Y1 = y;
            double X1 = x;
            double Da = d;
            double L = l;

            Point A = new Point(X1, Y1);
            Point B = GEOTask.FirstTask(A, Da, L);
            
            return (B);
        }
        //static void SecondTaskMenu()
        //{
        //    Console.WriteLine("Enter Easting A");
        //    double Y1 = InputDouble();
        //    Console.WriteLine("Enter Nothing A");
        //    double X1 = InputDouble();
        //    Console.WriteLine("Enter Easting B");
        //    double Y2 = InputDouble();
        //    Console.WriteLine("Enter Nothing B");
        //    double X2 = InputDouble();

        //    Point A = new Point(X1, Y1);
        //    Point B = new Point(X2, Y2);
        //    Shift S = GEOTask.SecondTask(A, B);
        //    Console.WriteLine("Координаты второй точки:");
        //    Console.WriteLine($"Дирекционный угол: {S.d:f2}; Дистанция: {S.l:f2}");

        //    Console.ReadKey();
        //}
        static public Shift SecondTaskMenuInterface(double x1, double y1, double x2, double y2)
        {
            double Y1 = y1;
            double X1 = x1;
            double Y2 = y2;
            double X2 = x2;            

            Point A = new Point(X1, Y1);
            Point B = new Point(X2, Y2);
            Shift S = GEOTask.SecondTask(A, B);          
            
            return (S);
        }
    }
}
