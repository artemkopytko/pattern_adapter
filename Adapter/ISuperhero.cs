using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter.Superheroes
{
    public interface ISuperhero
    {
		string Shoot();
		string Fly();
		string GoThrougWalls();
    }
}
