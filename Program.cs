using System;

namespace AnimalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog(true, true, 100);
            Cat cat = new Cat(true, true, 50);
            Frog frog = new Frog(false, false, 75);
            
            Console.WriteLine("Dog:");
            Console.WriteLine("mammals: " + (dog.Mammals?"yes":"no"));
            Console.WriteLine("carnivorous: " + (dog.Carnivorous ? "yes" : "no"));
            dog.SayHello();
            dog.SayHello(100);
            Console.WriteLine("Number of legs: " + dog.getNumberOfLegs());
            Console.WriteLine("**********");
            Console.WriteLine("Cat:");
            Console.WriteLine("mammals: " + (cat.Mammals ? "yes" : "no"));
            Console.WriteLine("carnivorous: ", (cat.Carnivorous ? "yes" : "no"));
            cat.SayHello();
            cat.SayHello(50);
            Console.WriteLine("Number of legs: " + cat.getNumberOfLegs());
            Console.WriteLine("**********");
            Console.WriteLine("Frog:");
            Console.WriteLine("mammals: " + (frog.Mammals ? "yes" : "no"));
            Console.WriteLine("carnivorous: " + (frog.Carnivorous ? "yes" : "no"));
            frog.SayHello();
            frog.SayHello(75);
            Console.WriteLine("Number of legs: " + frog.getNumberOfLegs());
            Console.ReadLine();
        }
    }
}