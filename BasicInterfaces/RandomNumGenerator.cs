using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace BasicInterfaces
{
    class RandomNumGenerator : IRandomizable
    {
        public static void Start()
        {
            Console.WriteLine("Enter 'exit' anytime to close the program.");
            string input = null;

            do
            {
                Console.WriteLine("Please enter integer number - of the maximum range to get Random Number: ");
                input = Console.ReadLine();

                // If input is empty then continue;
                input = input ?? "";

                if (input.ToLower() == "exit")
                {
                    break;
                }

                int upperBound = 0;
                if (int.TryParse(input, out upperBound))
                {
                    var cls = new RandomNumGenerator();
                    Console.WriteLine(cls.GetRandomNum(upperBound));
                }

            } while (input.ToLower() != "exit");
        }

        public float GetRandomNum(int upperBound)
        {
            var random = new Random(new Random().Next());
            random.Next(0, upperBound);
            return float.Parse(random.Next().ToString());
        }

    }

    interface IRandomizable
    {
        float GetRandomNum(int upperBound);
    }

}
