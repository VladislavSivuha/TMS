using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public static class Homework4
    {
        static Dictionary<int, string> menu = new Dictionary<int, string>()
        {
            {1, "Вывести матрицу" },
            {2, "Кол-во положительных/отрицательных значений" },
            {3, "Вывод четных/нечетных значений в строках" },
            {4, "Сколько раз использовалось число" },
            {5, "Завершение работы" }
        };

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
        public static void CreateArray()
        {
            int i = 0;
            do
            {
                Console.Write("Введите i размерность массива (< 6): ");
                i = StringToDouble(Console.ReadLine());
            } while (!(i > 0 && i < 6));

            int j = 0;
            do
            {
                Console.Write("Введите j размерность массива (< 6): ");
                j = StringToDouble(Console.ReadLine());
            }while(!(j > 0 && i < 6));

            int[,] ints = new int[i, j];
            Random random = new Random();
            for (int ii = 0; ii < i; ii++)
            {
                for (int jj = 0; jj < j; jj++)
                {
                    ints[ii, jj] = random.Next(-9, 9);
                }
            }

            bool exitProgram = false;
            while (!exitProgram)
            {
                int selectedMenu = CreateArray_ShowMenu();
                switch (selectedMenu)
                {
                    // Вывести матрицу
                    case 1:
                        for (int ii = 0; ii < i; ii++)
                        {
                            for (int jj = 0; jj < j; jj++)
                            {
                                Console.Write($"{ints[ii, jj]}\t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    // Кол-во положительных/отрицательных значений
                    case 2:
                        int positiveCount = 0;
                        int negativeCount = 0;
                        int zeroCount = 0;
                        
                        for (int ii = 0; ii < i; ii++)
                        {
                            for (int jj = 0; jj < j; jj++)
                            {
                                if (ints[ii, jj] > 0)
                                    positiveCount++;
                                else if(ints[ii, jj] < 0)
                                    negativeCount++;
                                else zeroCount++;
                            }
                        }

                        Console.WriteLine($">0: {positiveCount}");
                        Console.WriteLine($"<0: {negativeCount}");
                        Console.WriteLine($"==0: {zeroCount}");
                        break;
                    // Вывод четных/нечетных значений в строках
                    case 3:
                        for (int ii = 0; ii < i; ii++)
                        {
                            for (int jj = 0; jj < j; jj++)
                            {
                                if (true)
                                {

                                }
                                if (ii % 2 == 0)
                                {
                                    if (ints[ii, jj] % 2 == 0)
                                    {
                                        Console.Write($"{ints[ii, jj]}\t");
                                    }
                                    else
                                    {
                                        Console.Write("-\t");
                                    }
                                }
                                if (ii % 2 == 1)
                                {
                                    if (ints[ii, jj] % 2 != 0)
                                    {
                                        Console.Write($"{ints[ii, jj]}\t");
                                    }
                                    else
                                    {
                                        Console.Write("-\t");
                                    }
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                    // Сколько раз использовалось число
                    case 4:
                        break;
                    case 5:
                        exitProgram = true;
                        break;
                    default:
                        break;
                }
            }
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
        public static int CreateArray_ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("МЕНЮ");
            foreach (var item in menu)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine();
            
            int selectedMenu = 0;
            do
            {
                Console.Write("Выберите пункт меню: ");
                selectedMenu = StringToDouble(Console.ReadLine());
            } while (!(selectedMenu > 0 && selectedMenu <= menu.Keys.Max()));

            return selectedMenu;
        }
    }
}
