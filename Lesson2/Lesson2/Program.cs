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
        static void Menu()
        {
            myClass.platelen();
            Console.Clear();
            Console.WriteLine("Привет! Для  выбора задания, нажми на соотвтествующую клавишу");
            Console.WriteLine("\n1 - Task 1.\nНаписать метод, возвращающий минимальное из трех чисел.");
            Console.WriteLine("\n2 - Task 2.\nНаписать метод подсчета количества цифр числа.");
            Console.WriteLine("\n3 - Task 3.\nС клавиатуры вводятся числа, пока не будет введен 0.\n" +
                "Подсчитать сумму всех нечетных положительных чисел.");
            Console.WriteLine("\n4 - Task 4.\nРеализовать метод проверки логина и пароля.На вход подается логин и пароль.\n" +
                "На выходе истина, если прошел авторизацию, и ложь, если не прошел.\n(Логин: root, Password: GeekBrains).");
            Console.WriteLine("\n5 - Task 5.\nНаписать программу, которая запрашивает массу и рост человека,\n" +
                "вычисляет его индекс массы и сообщает,\nнужно ли человеку похудеть, набрать вес или все в норме;");
            Console.WriteLine("\n6 - Task 6.\n*Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.\n" +
                "Хорошим называется число, которое делится на сумму своих цифр.\n" +
                "Реализовать подсчет времени выполнения программы, используя структуру DateTime.");
            Console.WriteLine("\n0 - Exit");
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Program.Task1();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Program.Task2();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Program.Task3();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Program.Task4();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Program.Task5();
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    Program.Task6();
                    break;
                case ConsoleKey.D0:
                case ConsoleKey.Escape:
                    Console.WriteLine("Bye-bye");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Menu();
        }

   }
}
