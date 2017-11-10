using System;
namespace Adapter.WildCats
{
    public interface IWildCat
    {
		string Breed { get; }//Порода
		void Growl(); //Рычание
		void Scratch(); //Царапанье
	}
}
