using System;

namespace AbstractAssignment
{
    public class Bird: Animal
    {
        public int NumberOfWings { get; set; }
        public Bird()
        {
            Name = "Beebah";
            NumberOfWings = 2;
        }

        public Bird(string name)
        {
            Name = name;
        }
        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} says chirp chirp");
        }

        public override void Sleep()
        {
            Console.WriteLine("TTTTTTttttttttt");
        }
        
    }
}