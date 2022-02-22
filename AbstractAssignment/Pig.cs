using System;

namespace AbstractAssignment
{
    public class Pig: Animal
    {
        public Pig()
        {
            Name = "Piggy";
        }
        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} says oink oink");
        }

        
    }
}