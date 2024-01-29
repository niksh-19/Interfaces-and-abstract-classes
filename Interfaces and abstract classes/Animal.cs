using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_abstract_classes
{
    abstract class Animal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }

        public string getName()
        { 
            return Name;
        }
        public string getColour()
        {
            return Colour;
        }
        public int getAge()
        {
            return Age;
        }
        public void setName(string name)
        {
            Name = name;
        }
        public void setColour(string colour)
        {
            Colour = colour;
        }
        public void setAge(int age)
        { 
            Age = age;
        }
        public abstract void Eat();
    }
class Dog: Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
    }
class Cat: Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
    }
}
