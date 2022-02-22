using System;

namespace AbstractAssignment
{
    public class Dog: Animal
    {
        public Dog()
        {
            Name = "Zwei";
        }
        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} says bark bark");
        }
        
    }
}