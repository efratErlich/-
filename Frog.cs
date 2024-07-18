using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTest
{
    public class Frog:Animal,Water,Land
    {
        public int NumberOfLegs { get; set; }
        public Frog(bool mammals, bool carnivorous, int mood)
            : base(mammals, carnivorous, mood)
        {
            NumberOfLegs = 4;
        }
        public override void SayHello(int mood)
        {
            Console.WriteLine(mood == MOOD_HAPPY ? "Quack quack quack" : "plop into the water");
        }
        public int getNumberOfLegs()
        {
            return NumberOfLegs;
        }
        public bool hasGills()
        {
            return true;
        }
        public bool hasLayEggs()
        {
            return true;
        }
    }
}