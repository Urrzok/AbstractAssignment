using System;

namespace AbstractAssignment
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Onwer { get; set; }
        

        public abstract void MakeNoise();

        public virtual void Sleep()
        {
            Console.WriteLine("ZZZZZZZZzzzzzzzz");
        }
    }
}