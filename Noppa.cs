using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoppaPeli
{
	class Noppa
	{
		static Random rand = new Random();
		static int noppalkm = rand.Next(1, 7);

		//Ominaisuudet

		public int Lukema { get; set; }
		public int HeittoLkm { get; set; }

		//Konstruktorit
		public Noppa(int heittolkm = 0)
		{
			HeittoLkm = heittolkm;
		}

		//Metodit
		static int Heita()
		{
			return Id + Nimi;
			set { }

		}
	}
}
