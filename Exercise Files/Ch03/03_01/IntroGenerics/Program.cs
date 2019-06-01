using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroGenerics
{
    class Program
    {
        static void Main(string[] args) {
            int total = 0;


            foreach (int i in arrList) {
                total += i;
            }
            Console.WriteLine("The total is {0}\n\n", total);

            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }
    }
}
