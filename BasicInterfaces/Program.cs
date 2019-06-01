using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterfaces
{
    class Document
    {
        private string name;

        public Document(string s)
        {
            name = s;
            Console.WriteLine("Created a document with name '{0}'", s);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document("Test Document");


            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
