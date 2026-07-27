using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Homework8
    {

    }

    abstract class Animal
    {
        public string Name { get; set; }


        public void SetName(string name)
        { 
            Name = name;
        }
        public void GetName()
        {
            Console.WriteLine($"Имя животного: {Name}");
        }
        public abstract void Eat();
    }
    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine($"Собака ест");
        }
    }
}
