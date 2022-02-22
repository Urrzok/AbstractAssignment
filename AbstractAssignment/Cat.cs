using System;

namespace AbstractAssignment
{
    public class Cat: Animal
    {
        public Cat()
        {
            Name = "Rory";
        }
        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} says meow meow");
        }
        
    }
}