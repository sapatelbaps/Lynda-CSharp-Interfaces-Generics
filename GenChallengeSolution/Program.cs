using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenChallengeSolution
{
    public class ClassicCar
    {
        public string m_Make;
        public string m_Model;
        public int m_Year;
        public int m_Value;

        public ClassicCar(string make, string model, int year, int val)
        {
            m_Make = make;
            m_Model = model;
            m_Year = year;
            m_Value = val;
        }
    }

    public class ClassicCarComparer : IComparer<ClassicCar>
    {
        List<string> manufacturerList = new List<string>();

        public int Compare(ClassicCar x, ClassicCar y)
        {
            if (manufacturerList.Contains(x.m_Make))
            {
                return 0;
            }
            else
            {
                manufacturerList.Add(x.m_Make);
                return 1;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<ClassicCar> carList = new List<ClassicCar>();
            populateData(carList);

            // How many cars are in the collection?
            Console.WriteLine($"Total {carList.Count} cars are there in the collection.");

            // How many Fords are there?
            var findFords = carList.FindAll(FindFords);
            Console.WriteLine(findFords.Count);
            Console.WriteLine($"Total {carList.Count(c => c.m_Make.ToLower() == "ford")} Fords are there in the collection.");

            // What is the most valuable car?
            int maximumPrice = carList.Max(v => v.m_Value);
            ClassicCar mostValuableCar = carList.Single(x => x.m_Value == maximumPrice);
            Console.WriteLine($"The most valuable car is {mostValuableCar.m_Make} model {mostValuableCar.m_Model} worth amount {maximumPrice}");

            // What is the entire collection worth?
            Console.WriteLine($"The entire collection is worth ${carList.Sum(v => v.m_Value)}");

            // How many unique manufacturers are there?
            var query = (from c in carList select c.m_Make).ToList().Distinct().Count();
            Console.WriteLine($"There are total {query} number of manufacturers.");

            Console.WriteLine("\nHit Enter key to continue...");
            Console.ReadLine();
        }

        private static bool FindFords(ClassicCar car)
        {
            if (car.m_Make == "Ford")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void populateData(List<ClassicCar> theList)
        {
            theList.Add(new ClassicCar("Alfa Romeo", "Spider Veloce", 1965, 15000));
            theList.Add(new ClassicCar("Alfa Romeo", "1750 Berlina", 1970, 20000));
            theList.Add(new ClassicCar("Alfa Romeo", "Giuletta", 1978, 45000));

            theList.Add(new ClassicCar("Ford", "Thunderbird", 1971, 35000));
            theList.Add(new ClassicCar("Ford", "Mustang", 1976, 29800));
            theList.Add(new ClassicCar("Ford", "Corsair", 1970, 17900));
            theList.Add(new ClassicCar("Ford", "LTD", 1969, 12000));

            theList.Add(new ClassicCar("Chevrolet", "Camaro", 1979, 7000));
            theList.Add(new ClassicCar("Chevrolet", "Corvette Stringray", 1966, 21000));
            theList.Add(new ClassicCar("Chevrolet", "Monte Carlo", 1984, 10000));

            theList.Add(new ClassicCar("Mercedes", "300SL Roadster", 1957, 19800));
            theList.Add(new ClassicCar("Mercedes", "SSKL", 1930, 14300));
            theList.Add(new ClassicCar("Mercedes", "130H", 1936, 18400));
            theList.Add(new ClassicCar("Mercedes", "250SL", 1968, 13200));
        }
    }
}
