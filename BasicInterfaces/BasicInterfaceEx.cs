using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterfaces
{
    class BasicInterfaceEx
    {
        public static void Start()
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

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

    class Document : IStorable, IEncryptable
    {
        private string name;

        // INotifyPropertyChanged requires the implementation of 1 event
        public event PropertyChangedEventHandler PropertyChanged;

        // Utility function to call the PropertyChanged event
        private void NotifyPropChanged(string propName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public Document(string s)
        {
            name = s;
            Console.WriteLine("Created a document with name '{0}'", s);
        }

        public string DocName
        {
            get { return name; }
            set
            {
                name = value;
                NotifyPropChanged("DocName");
            }
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
            set
            {
                mNeedsSave = value;
                NotifyPropChanged("NeedsSave");
            }
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

}
