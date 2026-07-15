using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public static class Homework4
    {
        static Dictionary<int, string> menuForArray = new Dictionary<int, string>()
        {
            {1, "Вывести матрицу" },
            {2, "Кол-во положительных/отрицательных значений" },
            {3, "Вывод четных/нечетных значений в строках" },
            {4, "Сколько раз использовалось число" },
            {5, "Завершение работы" }
        };
        static Dictionary<int, string> menuForList = new Dictionary<int, string>()
        {
            {1, "Вывести List" },
            {2, "Добавить запись" },
            {3, "Удалить запись" },
            {4, "Заменить четные на х2, нечетные на х0" },
            {5, "Создать HashSet и вывести" },
            {6, "Завершение работы" }
        };

        public static void FormNTo1()
        {
            Console.Write("Введите число не равное 1: ");
            int num = StringToInt(Console.ReadLine());

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
            int count = StringToInt(Console.ReadLine());

            for (int i = 0; count >= 0; count--, i += 7)
                Console.WriteLine(i);
        }
        public static void PrintFibonacci()
        {
            Console.Write("Введите сколько чисел из последовательности Фибоначчи вывести: ");
            int count = StringToInt(Console.ReadLine());

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
                i = StringToInt(Console.ReadLine());
            } while (!(i > 0 && i < 6));

            int j = 0;
            do
            {
                Console.Write("Введите j размерность массива (< 6): ");
                j = StringToInt(Console.ReadLine());
            } while (!(j > 0 && i < 6));

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
                                else if (ints[ii, jj] < 0)
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
                        Dictionary<int, int> countNumbers = new Dictionary<int, int>();

                        for (int ii = 0; ii < i; ii++)
                        {
                            for (int jj = 0; jj < j; jj++)
                            {
                                if (!countNumbers.ContainsKey(ints[ii, jj]))
                                {
                                    countNumbers.Add(ints[ii, jj], 1);
                                }
                                else
                                {
                                    countNumbers[ints[ii, jj]]++;
                                }
                            }
                        }

                        foreach (var item in countNumbers.OrderBy(x => x.Key))
                        {
                            Console.WriteLine($"{item.Key} - {item.Value}");
                        }

                        break;
                    case 5:
                        exitProgram = true;
                        break;
                    default:
                        break;
                }
            }
        }
        public static void CreateList()
        {
            List<int> intList = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
                intList.Add(random.Next(-10, 10));

            bool exitProgram = false;
            while (!exitProgram)
            {
                int selectedMenu = CreateList_ShowMenu();
                switch (selectedMenu)
                {
                    // Вывести List
                    case 1:
                        ShowList(intList);
                        break;
                    // Добавить запись
                    case 2:
                        AddToList(ref intList);
                        break;
                    // Удалить запись
                    case 3:
                        RemoveFromList(ref intList);
                        break;
                    // Заменить четные на х2, нечетные на х0
                    case 4:
                        ChangeList(ref intList);
                        break;
                    // Создать HashSet и вывести
                    case 5:
                        CreateHashSetFromList(intList);
                        break;
                    // Завершение работы
                    case 6:
                        exitProgram = true;
                        break;
                    default:
                        break;
                }
            }
        }
        public static void ShowList(List<int> intList)
        {
            Console.WriteLine("Вывод List:");
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine($"[{i}] - {intList[i]}");
            }
        }
        public static void RemoveFromList(ref List<int> intList)
        {
            Console.Write($"Введите число [0-{intList.Count}]: ");
            intList.RemoveAt(StringToInt(Console.ReadLine()));
        }
        public static void AddToList(ref List<int> intList)
        {
            Console.Write("Введите число: ");
            intList.Add(StringToInt(Console.ReadLine()));
        }
        public static void ChangeList(ref List<int> intList)
        {
            List<int> newList = new List<int>();

            foreach (var item in intList)
            {
                if (item % 2 == 0)
                {
                    newList.Add(item * 2);
                }
                else
                {
                    newList.Add(item * 0);
                }
            }

            intList = newList;
            ShowList(intList);
        }
        public static void CreateHashSetFromList(List<int> intList)
        { 
            HashSet<int> set = new HashSet<int>(intList);

            Console.WriteLine("Вывод HashSet:");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }


        static int StringToInt(string stringNumber)
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
            Console.WriteLine("МЕНЮ для Array");
            foreach (var item in menuForArray)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine();

            int selectedMenu = 0;
            do
            {
                Console.Write("Выберите пункт меню: ");
                selectedMenu = StringToInt(Console.ReadLine());
            } while (!(selectedMenu > 0 && selectedMenu <= menuForArray.Keys.Max()));

            return selectedMenu;
        }
        public static int CreateList_ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("МЕНЮ для List");
            foreach (var item in menuForList)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine();

            int selectedMenu = 0;
            do
            {
                Console.Write("Выберите пункт меню: ");
                selectedMenu = StringToInt(Console.ReadLine());
            } while (!(selectedMenu > 0 && selectedMenu <= menuForList.Keys.Max()));

            return selectedMenu;
        }
    }
}
