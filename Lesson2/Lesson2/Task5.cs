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
        static void Task5()
        {
            myClass.platelen();
            Console.Clear();
            Console.Title = "Платонов Дмитрий(pLateLeN!), 30 лет, Воронеж.";
            Console.SetWindowSize(70, 15);
            Console.SetBufferSize(70, 15);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Привет!\nТебя приветствует программа по расчёту индекса массы тела(ИМТ)\nРасчёт идёт по формуле: I=m/(h*h);\nгде m — масса тела в килограммах, h — рост в метрах");
            double m, h;
            Console.Write("Введите свою массу в килограммах: ");
            m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите свой рост в метрах: ");
            h = Convert.ToDouble(Console.ReadLine());
            double sum = m / (h * h);
            Console.WriteLine("Ваш ИМТ: " + "{0:F1}", sum);

            if (sum <= 16)
            {
                Console.WriteLine("\nВыраженный дефицит массы тела!");
            }
            else if (sum <= 18)
            {
                Console.WriteLine("\nНедостаточная(дефицит) масса тела!");
            }
            else if (sum <= 25)
            {
                Console.WriteLine("\nВаш ИМТ в норме!");
            }
            else if (sum <= 30)
            {
                Console.WriteLine("\nИзбыточная масса тела (предожирение)!");
            }
            else if (sum <= 35)
            {
                Console.WriteLine("\nУ Вас ожирение!");
            }
            else if (sum <= 40)
            {
                Console.WriteLine("\nУ Вас ожирение резкое!");
            }
            else if (sum > 40)
            {
                Console.WriteLine("\nУ Вас Очень резкое ожирение!");
            }
            myClass.Pause();
        }
    }
}
