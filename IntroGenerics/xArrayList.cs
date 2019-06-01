using System;
using System.Collections;
using System.Collections.Generic;

namespace IntroGenerics
{
    class xArrayList
    {
        public static void Start()
        {
            int total = 0;

            // non-generic ArrayList can hold any object
            ArrayList arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add(2);
            arrList.Add(3);
            // arrList.Add("successful compilation as its Generic but runtime error - uncomment to test");

            // We can tell a Generic List what to hold
            List<int> xarrList = new List<int>();
            xarrList.Add(1);
            xarrList.Add(2);
            xarrList.Add(3);

            foreach (int i in arrList)
            {
                total += i;
            }
            Console.WriteLine("The total is {0}\n\n", total);

            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }
    }
}
