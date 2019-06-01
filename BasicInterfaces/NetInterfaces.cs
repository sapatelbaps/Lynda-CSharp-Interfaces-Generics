using System;
using System.ComponentModel;

namespace BasicInterfaces
{

    class NetInterfaces
    {
        public static void Start()
        {
            Document d = new Document("Test Document");

            d.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
            {
                Console.WriteLine("Document property changed: {0}", e.PropertyName);
            };

            d.DocName = "My Documents";
            d.NeedsSave = true;

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

}
