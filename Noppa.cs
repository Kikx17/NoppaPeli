using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoppaPeli
{
	class Noppa
	{
		static int rand = Random();
		//static Random rand = new Random();

		//Ominaisuudet

		public int Lukema { get; set; }
		public int HeittoLkm { get; set; }

		//Konstruktorit
		public Noppa(int heittolkm = 0)
		{
			HeittoLkm = heittolkm;
		}

		//Metodit
		public int Heita()
		{
			return Id + Nimi;
		}
	}
}
