using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_abstract_classes
{
    public interface IAnimal
    {
        string Name { get; set; }
        string Colour { get; set; }
        double Height { get; set; }
        int Age { get; set; }

        // Getter methods
        string getName();
        string getColour();
        double getHeight();
        int getAge();

        // Setter methods
        void setName(string name);
        void setColour(string colour);
        void setHeight(double height);
        void setAge(int age);

        // Abstract method
        void Eat();

        // Method with implementation
        string Cry();
    }
class Dog2 : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        public string getName() => Name;
        public string getColour() => Colour;
        public double getHeight() => Height;
        public int getAge() => Age;

        public void setName(string name) => Name = name;
        public void setColour(string colour) => Colour = colour;
        public void setHeight(double height) => Height = height;
        public void setAge(int age) => Age = age;

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }

        public string Cry()
        {
            return "Woof!";
        }
    }
 class Cat2 : IAnimal
    {
        // Properties
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        // Getter methods
        public string getName() => Name;
        public string getColour() => Colour;
        public double getHeight() => Height;
        public int getAge() => Age;

        // Setter methods
        public void setName(string name) => Name = name;
        public void setColour(string colour) => Colour = colour;
        public void setHeight(double height) => Height = height;
        public void setAge(int age) => Age = age;

        // Implementation of abstract method
        public void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }

        // Implementation of non-abstract method
        public string Cry()
        {
            return "Meow!";
        }
    }
}