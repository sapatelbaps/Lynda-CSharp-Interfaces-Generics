using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterfaces
{
    // Explicitly provide interface name in the derived class.
    class MultipleInterfaces
    {
        public static void Start()
        {
            #region Call same method for casting multiple interfaces. Remove implementation of two methods from the FooBar class to review the difference in result.

            xFooBar fbxBar = new xFooBar();
            fbxBar.SomeMethod();

            IFoo xifoo = fbxBar as IFoo;
            xifoo.SomeMethod();

            IBar xibar = fbxBar as IBar;
            xibar.SomeMethod();

            Console.WriteLine();

            FooBar fb = new FooBar();
            fb.SomeMethod();

            IFoo ifoo = fb as IFoo;
            ifoo.SomeMethod();

            IBar ibar = fb as IBar;
            ibar.SomeMethod();

            #endregion

        }
    }

    class xFooBar : IFoo, IBar
    {
        public void SomeMethod()
        {
            Console.WriteLine("This is the class SomeMethod");
        }
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
