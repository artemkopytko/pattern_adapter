using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter.Superheroes
{
    public class SuperheroAdapter: ISuperhero
    {
		private string _fly;

		private string _shoot;
		private string _walls;
		ISuperhero _hero;
		public SuperheroAdapter(ISuperhero hero)
		{
			_hero = hero;
			_fly = _hero.Fly();
			_shoot = _hero.Shoot();
			_walls = _hero.GoThrougWalls();
		}
		public string Shoot()
		{
			return _hero.Shoot();
		}
		public string Fly()
		{
			return _hero.Fly();
		}
		public string GoThrougWalls()
		{
			return _hero.GoThrougWalls();
		}
    }
}
