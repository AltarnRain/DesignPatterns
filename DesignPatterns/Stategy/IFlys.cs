// <copyright file="Flys.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Strategy
{
    // The interface is implemented by many other
    // subclasses that allow for many types of flying
    // without effecting Animal, or Flys.

    // Classes that implement new Flys interface
    // subclasses can allow other classes to use
    // that code eliminating code duplication

    // I'm decoupling : encapsulating the concept that varies

    public interface IFlys
    {
        string Fly();
    }

    // Class used if the Animal can fly
    public class ItFlys : IFlys
    {
        public string Fly()
        {
            return "Flying High";
        }
    }

    //Class used if the Animal can't fly
    public class CantFly : IFlys
    {
        public string Fly()
        {
            return "I can't fly";
        }
    }
}