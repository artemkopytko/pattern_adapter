﻿using System;
using Adapter.WildCats;
             
namespace Adapter.WildCats
{
    public class Tiger: IWildCat
    {
		public string Breed 
        { get 
            { return "Тигр обыкновенный"; 
            } 
        }

		public void Growl()
		{
			Console.WriteLine("Grrrrrrr");
		}

		public void Scratch()
		{
			Console.WriteLine("У меня очень острые когти, царапаюсь до смерти");
		}
    }
}
