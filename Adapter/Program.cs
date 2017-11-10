using System;
//using Adapter.Adapters;
using Adapter.HomeCats;
using Adapter.WildCats;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
			IHomeCat vaska = new YardCat();
			vaska.Name = "Васька";
			CatInfoPrinter.PrintCatInfo(vaska);

			IHomeCat wagner = new PedigreedCat();
			wagner.Name = "Вагнер";
			CatInfoPrinter.PrintCatInfo(wagner);

			Console.ReadLine();
        }
    }
}
