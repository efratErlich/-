using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTest
{
    public class Cat : Animal, Land
    {
        public int NumberOfLegs { get; set; }
        public Cat(bool mammals, bool carnivorous, int mood)
            : base(mammals, carnivorous, mood)
        {
            Mammals = true;
            Carnivorous = true;
            NumberOfLegs = 4;
        }
        public void SayHello()
        {
            Console.WriteLine("Meow~");
        }
        public override void SayHello(int mood)
        {
            Console.WriteLine(mood == MOOD_HAPPY ? "Purr, purr" : "Hiss");
        }
        public int getNumberOfLegs()
        {
            return NumberOfLegs;
        }
    }
}