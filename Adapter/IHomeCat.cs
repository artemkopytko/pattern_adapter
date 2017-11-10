using System;
namespace Adapter.HomeCats
{
    interface IHomeCat
    {
        string Name { get; set; }
        void Meow();
        void Scratch();
    }
}
