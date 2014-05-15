using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryPatternTest.Types
{
	public class Moon
	{
		public int MoonId;
		public string Name;
		public string Orbit;
		public bool IsMadeOfCheese;

		public Moon ()
		{
		}

		public Moon(int moonId, string name, string orbit, bool isMadeOfCheese)
		{
			MoonId = moonId;
			Name = name;
			Orbit = orbit;
			IsMadeOfCheese = isMadeOfCheese;
		}
	}
}

