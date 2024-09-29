//**************************************************
//*Практическая работа № 1                         *
//*Выполнила: Корнеева В.Е., группа 2ИСП           *
//*Задание: Составить программу линейного алгоритма*
//**************************************************
using System;

namespace PR_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа №4";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Здраствуйте!");
            Console.Write("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double t1, t2, t3, t4, t5, t6, t7, t8, t9,t10, s;
            t1 = Math.Pow(10, 1/3);
            t2 = Math.Pow(a, 3 * Math.Abs(b));
            t3 = 1 / t2;
            t4 = Math.Pow(b, 4);
            t5 = Math.Pow(c, 1/2);
            t6 = t3 * t4 * t5;
            t8 = t1 + t6;
            t9 = Math.Log10(t8);
            t10 = Math.Pow(Math.E, a * b * Math.Pow(c, -2));
            s = t9 + t10;
            Console.WriteLine("Результат: " + Math.Round(s, 4));
            Console.ReadKey();
        }
    }
}
