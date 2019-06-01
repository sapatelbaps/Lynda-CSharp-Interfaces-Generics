using System;

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
