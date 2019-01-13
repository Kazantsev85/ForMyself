using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение прямых и обратных геодезических задач");
            Console.ReadKey();
            string m;
            do
            {
                Menu(); // Вызывает меню
                m = Console.ReadLine();
                switch (m)
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
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
        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Выберите задачу:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Нажите 1 для решения прямой геодезической задачи и 2 для решения обратной геодезической задачи");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Выход: 0");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Task1()
        {
            Console.WriteLine("Решение прямой геодезической задачи в разработке");
            Console.ReadKey();
        }
        static void Task2()
        {
            Console.WriteLine("Решение обратной геодезической задачи в разработке");
            Console.ReadKey();
        }
        static void Default()
        {
            Console.WriteLine("Неверно!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
