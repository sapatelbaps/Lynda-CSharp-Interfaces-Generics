using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterfaces
{
    class Document : IStorable
    {
        private string name;

        public Document(string s)
        {
            name = s;
            Console.WriteLine("Created a document with name '{0}'", s);
        }

        private Boolean mNeedsSave = false;

        public void Save()
        {
            Console.WriteLine("Saving the document");
        }

        public void Load()
        {
            Console.WriteLine("Loading the document");
        }

        public Boolean NeedsSave
        {
            get { return mNeedsSave; }
            set { mNeedsSave = value; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document("Test Document");

            // Use the 'is' operator
            if (d is IStorable)
            {
                d.Save();
            }

            // Use the 'as' operator
            IStorable intStor = d as IStorable;
            if (intStor != null)
            {
                d.Load();
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

    interface IStorable
    {
        void Save();
        void Load();
        Boolean NeedsSave { get; set; }
    }

}
