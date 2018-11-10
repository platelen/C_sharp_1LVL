using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tittle;

namespace Empty
{
    class Program
    {
        static void Recurs(int a, int b)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("Пожалуйста, введи первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введи второе число: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0,4}", a);
            if (a < b)
                Recurs(a + 1, b);
        }

        static void Main(string[] args)
        {

            myClass.platelen();
            Console.Clear();
            Recurs(14, 50);
            Console.ReadLine();


            //    Loop(1);
            //    myClass.platelen();
            //int x;
            //Console.WriteLine("Введиде целое число: ");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(x + "-" + ((x % 2 == 0) ? "чётное число" : "нечётное число"));
            //Console.WriteLine("Для выхода из приложения нажмите Enter");
            //Console.ReadLine();


            //int m = 6;
            //string s;
            //switch (m)
            //{
            //    case 1:
            //    case 2:
            //    case 12: s = "Зима";
            //        break;
            //    case 3:
            //    case 4:
            //    case 5: s = "Весна";
            //        break;
            //    case 6:
            //    case 7:
            //    case 8: s = "Лето";
            //        break;
            //    case 9:
            //    case 10:
            //    case 11: s = "Осень";
            //        break;
            //    default:
            //        s = "Ничего";
            //        break;
            //}
            //Console.WriteLine(s);
            //Console.ReadLine();

            #region Вложенный цикл

            //bool flag = true;
            //// Внешний цикл
            //for (int i = 0; i < 80 && flag; ++i)
            //    // Внутренний цикл
            //    for(int j = 0; j< 24 && flag; j++)
            //    {
            //        Console.SetCursorPosition(j, i);// Устанавливаем позицию курсора
            //        Console.Write('*');
            //        System.Threading.Thread.Sleep(400); //Делаем паузу
            //        Console.Title = "i=" + i + "j=" + j;
            //        if (i == 3 && j == 10) //flag = folse
            //            return;
            //    }
            //myClass.Pause();
            #endregion

            //string s = "Hello, Foreach";
            //foreach (char c in s)
            //    Console.Write("{0} ", c);
            //Console.ReadLine();





        }
    }
}
