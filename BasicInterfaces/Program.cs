using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterfaces
{
    class Document : IStorable, IEncryptable
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

        public void Encrypt()
        {
            Console.WriteLine("Encrypting the document");
        }

        public void Decrypt()
        {
            Console.WriteLine("Decrypting the document");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document("Test Document");

            #region is/as operators and multiple interfaces implementation.

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

            d.Load();
            d.Encrypt();
            d.Save();
            d.Decrypt();
            d.NeedsSave = false;

            #endregion

            #region Call same method for casting multiple interfaces. Remove implementation of two methods from the FooBar class to review the difference in result.

            FooBar fb = new FooBar();
            fb.SomeMethod();

            IFoo ifoo = fb as IFoo;
            ifoo.SomeMethod();

            IBar ibar = fb as IBar;
            ibar.SomeMethod();

            #endregion

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

    interface IEncryptable
    {
        void Encrypt();
        void Decrypt();
    }

    interface IFoo
    {
        void SomeMethod();
    }
    interface IBar
    {
        void SomeMethod();
    }

    class FooBar : IFoo, IBar
    {
        public void SomeMethod()
        {
            Console.WriteLine("This is the class SomeMethod");
        }

        void IFoo.SomeMethod()
        {
            Console.WriteLine("This is IFoo's SomeMethod");
        }

        void IBar.SomeMethod()
        {
            Console.WriteLine("This is IBar's SomeMethod");
        }
    }

}
