using System;
using Adapter.HomeCats;
using Adapter.WildCats;

namespace Adapter.Adapters
{
    class HomeCatAdapter : IHomeCat
    {
        private IWildCat _wildCat;
        public HomeCatAdapter(IWildCat wildCat)
        {
            _wildCat = wildCat;
        }
        public string Name
        {
            get { return _wildCat.Breed; }
            set { } //Мы не можем задавать породу для дикой кошки
        }
        public void Meow()
        {
            _wildCat.Growl();
        }
        public void Scratch()
        {
            _wildCat.Scratch();
        }
    }
}

