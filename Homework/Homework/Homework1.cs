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
    }
}
