using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public static class Homework4
    {
        public static void FormNTo1()
        {
            Console.Write("Введите число не равное 1: ");
            int num = StringToDouble(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("Число уже равно 1");
            }
            else if (num > 1)
            {
                for (; num >= 1; num--)
                {
                    Console.WriteLine(num);
                }
            }
            else
            {
                for (; num <= 1; num++)
                {
                    Console.WriteLine(num);
                }
            }
        }
        public static void PlusSeven()
        {
            Console.Write("Введите сколько раз прибавить 7: ");
            int count = StringToDouble(Console.ReadLine());

            for (int i = 0; count >= 0; count--, i += 7)
                Console.WriteLine(i);
        }
        public static void PrintFibonacci()
        {
            Console.Write("Введите сколько чисел из последовательности Фибоначчи вывести: ");
            int count = StringToDouble(Console.ReadLine());

            List<int> fibonacciList = new List<int>();
            for (int i = 0; i < count; i++)
            {
                if (fibonacciList.Count == 0)
                    fibonacciList.Add(0);
                else if (fibonacciList.Count == 1)
                    fibonacciList.Add(1);
                else
                    fibonacciList.Add(fibonacciList[fibonacciList.Count - 1] + fibonacciList[fibonacciList.Count - 2]);
            }

            Console.WriteLine("Вывод последовательности Фибоначчи");
            foreach (int i in fibonacciList) { Console.WriteLine(i); }
        }




        static int StringToDouble(string stringNumber)
        {
            int num = 0;
            while (!int.TryParse(stringNumber, out num))
            {
                Console.Write("ОШИБКА! Введите число! ");
                stringNumber = Console.ReadLine();
            }
            return num;
        }
    }
}
