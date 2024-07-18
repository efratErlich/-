using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTest
{
    public class Dog : Animal, Land
    {
        public int NumberOfLegs { get; set; }
        public Dog(bool mammals, bool carnivorous, int mood)
            : base(mammals, carnivorous, mood)
        {
            Mammals = true;
            Carnivorous = true;
            NumberOfLegs = 4;
        }
        public void SayHello()
        {
            Console.WriteLine("Wanning my tail!");
        }
        public override void SayHello(int mood)
        {
            Console.WriteLine(mood == MOOD_HAPPY ? "Whoa! Whoa!" : "whoop!");
        }
        public int getNumberOfLegs()
        {
            return NumberOfLegs;
        }
    }
}