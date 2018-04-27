using System;

namespace DesignPaterns.Strategy
{
    public class Animal
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public string FavFood { get; set; }
        public double Speed { get; set; }
        public string Sound { get; set; }

        private int weight;
        public int Weight
        {
            get { return this.weight; }
            set
            {
                if (value > 0)
                {
                    this.weight = value;
                }
                else
                {
                    Console.WriteLine("Weight must be bigger than 0");
                }
            }
        }

        // Instead of using an interface in a traditional way
        // we use an instance variable that is a subclass
        // of the Flys interface.

        // Animal doesn't care what flyingType does, it just
        // knows the behavior is available to its subclasses

        // This is known as Composition : Instead of inheriting
        // an ability through inheritance the class is composed
        // with Objects with the right ability

        // Composition allows you to change the capabilities of 
        // objects at run time!

        public IFlys FlyingType { get; set; }


        // Animal pushes off the responsibility for flying to flyingType
        public string TryToFly()
        {
            return FlyingType.Fly();
        }
    }
}