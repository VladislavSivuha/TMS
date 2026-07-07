using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public static class Homework1
    {
        public static void Questionnaire()
        {
            Console.WriteLine("\t\tЗАПОЛНЕНИЕ АНКЕТЫ");
            
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            
            Console.Write("Введите ваш возраст: ");
            int age = 0;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("ОШИБКА! Введите число! ");
            }
            
            Console.Write("Введите ваш рост (в метрах): ");
            double height = 0;
            while (!double.TryParse(Console.ReadLine().Replace('.', ','), out height))
            {
                Console.Write("ОШИБКА! Введите число! ");
            }

            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Рост: {height}");
        }
        public static void SwapNumbers()
        {
            Console.WriteLine("\t\tОБМЕН ЧИСЕЛ");

            Console.Write("Введите число №1: ");
            int num1 = 0;
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("ОШИБКА! Введите число! ");
            }
            
            Console.Write("Введите число №2: ");
            int num2 = 0;
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("ОШИБКА! Введите число! ");
            }

            Console.WriteLine($"Число №1/№2 - {num1}/{num2}");

            int numTmp = num1;
            num1 = num2;
            num2 = numTmp;

            Console.WriteLine($"Число №1/№2 - {num1}/{num2}");
        }
        public static void СalculateMetrics()
        {
            Console.WriteLine("\t\tКАЛЬКУЛЯТОР ПЛОЩАДИ");

            Console.Write("Введите длину стороны А (можно дробное): ");
            double sideA = 0;
            while (!double.TryParse(Console.ReadLine().Replace('.', ','), out sideA))
            {
                Console.Write("ОШИБКА! Введите число! ");
            }
            
            Console.Write("Введите длину стороны Б (можно дробное): ");
            double sideB = 0;
            while (!double.TryParse(Console.ReadLine().Replace('.', ','), out sideB))
            {
                Console.Write("ОШИБКА! Введите число! ");
            }

            Console.WriteLine($"Площадь фигуры: {Math.Round(sideA * sideB, 5)}");
            Console.WriteLine($"Периметр фигуры: {Math.Round(sideA * 2 + sideB * 2, 5)}");
        }
    }
}
