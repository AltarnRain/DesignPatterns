using System;

namespace DesignPaterns.Strategy
{
    public class Dog : Animal
    {
        public void DigHole()
        {
            Console.WriteLine("Dug a hole");
        }

        public Dog() : base()
        {
            this.Sound = "Bark";

            // We set the Flys interface polymorphically
            // This sets the behavior as a non-flying Animal
            FlyingType = new CantFly();
        }
    }
}