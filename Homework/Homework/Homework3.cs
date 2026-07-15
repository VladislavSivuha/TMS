using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public static class Homework3
    {
        enum Operation
        {
            Addition = 1,
            Subtraction = 2,
            Multiplication = 3,
            Division = 4,
            Percent = 5,
            SquareRoot = 6
        }
        public static void Calculator()
        {
            bool exitProgram = false;

            while (!exitProgram)
            {
                #region Ввод первого числа
                Console.Write("Введите первое число: ");
                double num1 = StringToDouble(Console.ReadLine().Replace('.', ','));
                #endregion

                #region Выбор оператора
                Console.Write($"Выберите операцию:\n{ShowOperationsList()}");
                int operationNumber;
                while (!int.TryParse(Console.ReadLine(), out operationNumber) || !(operationNumber >= 1 && operationNumber <= 6))
                {
                    Console.Write("ОШИБКА! Введите номер операции! ");
                }
                #endregion

                #region Ввод второго числа (если нужно)
                double num2 = 0;
                if (operationNumber >= 0 && operationNumber <= 5)
                {
                    Console.Write("Введите второе число: ");
                    num2 = StringToDouble(Console.ReadLine().Replace('.', ','));
                }
                #endregion

                #region Вывод результата
                switch (operationNumber)
                {
                    //Addition
                    case 1:
                        Console.WriteLine($"РЕЗУЛЬТАТ: {num1 + num2}");
                        break;
                    //Subtraction
                    case 2:
                        Console.WriteLine($"РЕЗУЛЬТАТ: {num1 - num2}");
                        break;
                    //Multiplication
                    case 3:
                        Console.WriteLine($"РЕЗУЛЬТАТ: {num1 * num2}");
                        break;
                    //Division
                    case 4:
                        Console.WriteLine($"РЕЗУЛЬТАТ: {num1 / num2}");
                        break;
                    //Percent
                    case 5:
                        Console.WriteLine($"РЕЗУЛЬТАТ: {(num1 * num2) / 100}");
                        break;
                    //SquareRoot
                    case 6:
                        Console.WriteLine($"РЕЗУЛЬТАТ: {Math.Sqrt(num1)}");
                        break;
                }
                #endregion

                #region Предложение завершить программу
                Console.WriteLine("Завершить работу программы?");
                string key = "";
                while (!(key.ToUpper() == "Y" || key.ToUpper() == "N"))
                {
                    Console.Write("Y/N: ");
                    key = Console.ReadLine();
                }
                exitProgram = key.ToUpper() == "Y" ? true : false;
                #endregion
            }
        }
        static string ShowOperationsList()
        {
            string result = "";

            foreach (var operation in Enum.GetValues<Operation>())
            {
                result += $"{(int)operation} - {operation}\n";
            }

            return result;
        }
        static double StringToDouble(string stringNumber)
        {
            double num = 0;
            while (!double.TryParse(stringNumber, out num))
            {
                Console.Write("ОШИБКА! Введите число! ");
            }
            return num;
        }
    }
}
