using System;

namespace AbstractAssignment
{
    public class Snake : Animal
    {
        public Snake()
        {
            Name = "Rattle";
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} says ssssssssss");
        }

        public override void Sleep()
        {
            Console.WriteLine("szszszszszszsz");
        }
    }
}