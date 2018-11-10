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
        static void Task6()
        {
            myClass.platelen();
            Console.Clear();
            int goodnumcount = 0;
            int minnum = 1;
            int maxnum = 1000000;
            int temp;
            int testnum;
            DateTime start = DateTime.Now;
            for (int num = minnum; num <= maxnum; num++)
            {
                temp = 0;
                testnum = num;
                while (testnum != 0)
                {
                    temp += testnum % 10;
                    testnum /= 10;
                }
                if (num % temp == 0) goodnumcount++;

            }
            System.Threading.Thread.Sleep(1000);
            DateTime finish = DateTime.Now;
            TimeSpan ts = finish - start;
            Console.WriteLine("Количество суммы хороших чисел: " + $"{goodnumcount}");
            Console.WriteLine("Времени прошло: " + ts);
            myClass.Pause();
        }
    }
}
