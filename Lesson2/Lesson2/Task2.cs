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
        
        static void Task2()
        {
            myClass.platelen();
            Console.Clear();
            Console.Title = "Платонов Дмитрий(pLateLeN!), 30 лет, Воронеж.";
            Console.SetWindowSize(65, 15);
            Console.SetBufferSize(65, 15);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Привет! Сейчас мы подсчитаем колл-во цифр числа!\nПоехали...");
                int N;
                int k = 0;
            Console.Write("\nВведите число: ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество цифр числа: " + $"{N}");
                while (N != 0)
                {
                    k++;
                    N /= 10;
                }
            Console.WriteLine($"Будет равна: {k}");
            myClass.Pause();

        }
    }
}
