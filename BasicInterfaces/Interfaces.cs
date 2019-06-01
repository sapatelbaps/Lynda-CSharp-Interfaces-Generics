using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterfaces
{
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

}
