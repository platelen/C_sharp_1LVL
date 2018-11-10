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
        static void Task3()
        {
            int sum = 0;
            int num = 0;
            myClass.platelen();
            Console.Clear();
            Console.Title = "Платонов Дмитрий(pLateLeN!), 30 лет, Воронеж.";
            Console.SetWindowSize(70, 15);
            Console.SetBufferSize(70, 15);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Привет! Сейчас мы подсчитаем сумму всех нечетных положительных чисел!");
            Console.WriteLine("\nВводите цифру и нажимайте \"Enter\", пока не наберёте \"0\".");
            Console.WriteLine("\nПоехали:");
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0 && num % 2 == 1)
                    sum += num;

            } while (num != 0);

            Console.WriteLine("Cумма нечётных положительных цифр: " + sum);
            myClass.Pause();
        }
    }
}
