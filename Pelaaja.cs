using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoppaPeli
{
	class Pelaaja : INimi
	{
		//Automaattiset ominaisuudet
		public string Nimi { get; set; }
		public int Pisteet { get; set; }

		//Konstruktorit
		public Pelaaja(string nimi, int pisteet)
			: this(nimi, pisteet)
		{

		}
		public Pelaaja(string Pelaaja1nimi, int pisteet)
			: this(Pelaaja1nimi, pisteet)
		{

		}
		public Pelaaja(string nimi, int pisteet = 0)
		{
			Nimi = nimi;
			Pisteet = pisteet;
		}
	}
}
