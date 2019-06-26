using System;

namespace BasicInterfaces
{
    class Solution : IxRandomizable
    {
        public static void Start()
        {
            string input;
            do
            {
                Console.WriteLine("Enter number for upper bound: ");
                input = Console.ReadLine();
                try
                {
                    double upperBound = double.Parse(input);
                    Solution cls = new Solution();
                    Console.WriteLine($"Random number between 0 and ${upperBound}: , {cls.GetRandomNum(upperBound)}");
                }
                catch (Exception e) { }

            } while (input.ToLower() != "exit");
        }

        public double GetRandomNum(double upperBound)
        {
            Random cls = new Random();
            double seed = cls.NextDouble();
            return seed * upperBound;
        }
    }

    interface IxRandomizable
    {
        double GetRandomNum(double upperBound);
    }
}
