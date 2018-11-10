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
        static void Task4()
        {
            myClass.platelen();
            Console.Clear();

            string logo = "";
            string pas = "";
            string masterLogo = "root";
            string masterPas = "GeekBrains";
            int count = 3;

            Console.Title = "Платонов Дмитрий(pLateLeN!), 30 лет, Воронеж.";
            Console.SetWindowSize(65, 15);
            Console.SetBufferSize(65, 15);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Введите пожалуйста \"Логин\" и \"Пароль\": ");
            Console.Write("login: ");
            logo = Console.ReadLine();
            Console.Write("password: ");
            pas = Console.ReadLine();
            do
            {

                if (logo == masterLogo && pas == masterPas)
                {
                    Console.WriteLine("Добро пожаловать в IT-портал \"GeekBrains\"");
                    myClass.Pause();
                    break;
                }
                else
                {
                    Console.WriteLine("\nЛогин или пароль неверный!");
                    count--;
                    Console.WriteLine("У вас осталось: " + $"{count} попыток\nПопробуйте ещё раз!");
                    Console.ReadLine();
                    Console.WriteLine("Введите пожалуйста \"Логин\" и \"Пароль\"");
                    Console.Write("login: ");
                    logo = Console.ReadLine();
                    Console.Write("password: ");
                    pas = Console.ReadLine();
                }

            }
            while (count >= 0);
        }
    }
}
