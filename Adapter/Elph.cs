using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter.Superheroes
{
    public class Elph: ISuperhero
    {
		public string Shoot()
		{
			return "Я забрасываю розами!";
		}

		public string Fly()
		{
			return "Я только летаю!";
		}

		public string GoThrougWalls()
		{
			return "Я пролетаю сквозь стены!";
		}
    }
}
