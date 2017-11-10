using System;
using Adapter.Adapters;
using Adapter.HomeCats;
using Adapter.WildCats;
using Adapter.Superheroes;

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

			IWildCat tiger = new Tiger();
			HomeCatAdapter adapter = new HomeCatAdapter(tiger);
			CatInfoPrinter.PrintCatInfo(adapter);

            ISuperhero elph = new Elph();
			SuperheroAdapter superheroAdapteradapter = new SuperheroAdapter(elph);
			Console.WriteLine("Досье для героя: {0} {1} {2}", superheroAdapteradapter.Fly(),
			superheroAdapteradapter.Shoot(), superheroAdapteradapter.GoThrougWalls());

			Console.ReadLine();
        }
    }
}
