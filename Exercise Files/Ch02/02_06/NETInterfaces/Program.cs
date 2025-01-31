﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NETInterfaces
{
    interface IStorable
    {
        void Save();
        void Load();
        Boolean NeedsSave { get; set; }
    }

    class Document : IStorable
    {
        private string name;
        private Boolean mNeedsSave = false;


        public Document(string s) {
            name = s;
            Console.WriteLine("Created a document with name '{0}'", s);
        }

        public string DocName {
            get { return name; }
            set { 
                name = value;
            }
        }

        public void Save() {
            Console.WriteLine("Saving the document");
        }

        public void Load() {
            Console.WriteLine("Loading the document");
        }

        public Boolean NeedsSave {
            get { return mNeedsSave; }
            set { 
                mNeedsSave = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args) {
            Document d = new Document("Test Document");


            // Change a couple properties to trigger the event
            d.DocName = "My Document";
            d.NeedsSave = true;

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
