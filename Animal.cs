using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTest
{
    public abstract class Animal
    {
        public bool Mammals { get; set; }
        public bool Carnivorous { get; set; }
        public int MOOD_HAPPY { get; set; }
        public int MOOD_SCARE { get; set; }


        public Animal(bool mammals, bool carnivorous, int mood)
        {
            Mammals = mammals;
            Carnivorous = carnivorous;
            MOOD_HAPPY = mood;//בהנחה שמצב הרוח הוא טוב
            MOOD_SCARE = 0;//כברירת מחדל

        }
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
        public abstract void SayHello(int mood);
        public bool IsMammals()
        {
            return Mammals;
        }
        public void SetMammals(bool mammals)
        {
            Mammals = mammals;
        }
        public bool IsCarnivorous()
        {
            return Carnivorous;
        }
        public void SetCarnivorous(bool carnivorous)
        {
            Carnivorous = carnivorous;
        }
    }
}