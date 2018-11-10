using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tittle;

namespace Menu

{
    partial class Program
    {
        static void Task1()
        {

            int a, b, c, min;
            min = 0;

            myClass.platelen();
            Console.Clear();
            Console.Title = "Платонов Дмитрий(pLateLeN!), 30 лет, Воронеж.";
            Console.SetWindowSize(65, 15);
            Console.SetBufferSize(65, 15);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ку-ку ;)\nПодсчитываем минимальное число из трёх!");
            Console.Write("Введите первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            c = Convert.ToInt32(Console.ReadLine());


            if (a < b && a < c)

                min = a;

            else if (a > c && b > c)

                min = c;

            else if (b < a && b < c)

                min = b;

            Console.WriteLine("\nНаименьшее число: " + $"{min}");
            myClass.Pause();

        }
    }
}