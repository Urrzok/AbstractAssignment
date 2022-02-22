using System;
using System.Collections.Generic;

namespace AbstractAssignment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PetStore petStore = new PetStore();
           
            var choice = "";

            Animal animal = null;
            do
            {
                Console.WriteLine("Which animal do you want to hear?\n1 Pig\n2 Dog\n3 Cat\n4 Bird\n5 Snake\n6 To Exit");
                choice = Console.ReadLine();
                if (choice == "1")
                { 
                    animal = new Pig();
                }
                else if (choice == "2")
                {
                    animal = new Dog();
                }
                else if (choice == "3")
                {
                    animal = new Cat();
                }
                else if (choice == "4")
                {
                    animal = new Bird("birdy");
                }
                else if (choice == "5")
                {
                    animal = new Snake();
                }
                animal?.MakeNoise();
                animal?.Sleep();
            } while (choice != "6");
            
            

        }
    }



}