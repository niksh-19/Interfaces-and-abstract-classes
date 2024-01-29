namespace Interfaces_and_abstract_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1 
            Console.WriteLine("Enter dog name: ");
            string dogName = Console.ReadLine();
            
            // Create Dog object
            Dog myDog = new Dog();
            myDog.setName(dogName);
            myDog.setColour("Brown");
            myDog.setAge(4);

            // Display information using getter methods
            Console.WriteLine($"Dog Name: {myDog.getName()}");
            Console.WriteLine($"Dog Colour: {myDog.getColour()}");
            Console.WriteLine($"Dog Age: {myDog.getAge()}");

            // Call the Eat method
            myDog.Eat();

            Console.WriteLine();

            // Test with Cat
            Console.WriteLine("Enter a cat name:");
            string catName = Console.ReadLine();

            // Create Cat object
            Cat myCat = new Cat();
            myCat.setName(catName);
            myCat.setColour("Grey");
            myCat.setAge(2);

            // Display information using getter methods
            Console.WriteLine($"Cat Name: {myCat.getName()}");
            Console.WriteLine($"Cat Colour: {myCat.getColour()}");
            Console.WriteLine($"Cat Age: {myCat.getAge()}");

            // Call the Eat method
            myCat.Eat();

            // part 2
            Console.WriteLine("Enter a dog name:");
            string dogName2 = Console.ReadLine();
            Dog2 myDog2 = new Dog2();
            myDog2.setName(dogName2);

            Console.WriteLine($"Dog Name: {myDog2.getName()}");

            Console.WriteLine("Enter dog height in cm:");
            double dogHeight = Convert.ToDouble(Console.ReadLine());
            myDog2.setHeight(dogHeight);

            Console.WriteLine("Enter dog colour:");
            string dogColour2 = Console.ReadLine();
            myDog2.setColour(dogColour2);

            Console.WriteLine("Enter dog age:");
            int dogAge2 = Convert.ToInt32(Console.ReadLine());
            myDog2.setAge(dogAge2);

            Console.WriteLine($"Dog Height: {myDog2.getHeight()} cm");
            Console.WriteLine($"Dog Colour: {myDog2.getColour()}");
            Console.WriteLine($"Dog Age: {myDog2.getAge()} years");

            myDog2.Eat();
            Console.WriteLine($"Dog says: {myDog2.Cry()}");

            Console.WriteLine();

            Console.WriteLine("Enter a cat name:");
            string catName2 = Console.ReadLine();
            Cat2 myCat2 = new Cat2();
            myCat2.setName(catName2);

            Console.WriteLine($"Cat Name: {myCat2.getName()}");

            Console.WriteLine("Enter cat height in cm:");
            double catHeight = Convert.ToDouble(Console.ReadLine());
            myCat2.setHeight(catHeight);

            Console.WriteLine("Enter cat colour:");
            string catColour2 = Console.ReadLine();
            myCat2.setColour(catColour2);

            Console.WriteLine("Enter cat age:");
            int catAge2 = Convert.ToInt32(Console.ReadLine());
            myCat2.setAge(catAge2);

            Console.WriteLine($"Cat Height: {myCat2.getHeight()} cm");
            Console.WriteLine($"Cat Colour: {myCat2.getColour()}");
            Console.WriteLine($"Cat Age: {myCat2.getAge()} years");

            myCat2.Eat();
            Console.WriteLine($"Cat says: {myCat2.Cry()}");

            Console.WriteLine();

            // Part 2 - List of Animals
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(myDog2);
            animals.Add(myCat2);

            Console.WriteLine("Names of all animals:");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.getName());
            }
        }
    }
}
    
