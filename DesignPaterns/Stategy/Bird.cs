namespace DesignPaterns.Strategy
{
    public class Bird : Animal
    {
        // The constructor initializes all objects
        /// <summary>
        /// Initializes a new instance of the <see cref="Bird"/> class.
        /// </summary>
        public Bird() : base()
        {
            this.Sound = "Tweet";

            // We set the Flys interface polymorphically
            // This sets the behavior as a non-flying Animal
            FlyingType = new ItFlys();
        }
    }
}