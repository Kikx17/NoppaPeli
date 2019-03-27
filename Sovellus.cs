using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoppaPeli
{
	static class Sovellus
	{
		//Kenttämuuttujat
		static int VOITONPISTERAJA = 3;

		public static int DiceThrow1 { get; private set; }
		public static int DiceThrow0 { get; private set; }

		//Metodit
		static void Aja()
		{
			Console.WriteLine("Noppa-peli\n Pelaajan 1 nimi: ");
			var Pelaaja1nimi = Console.ReadLine();

			string Player0;
			string Player1;
			int PlayerTotal0;
			int PlayerTotal1;
			Console.Write("Noppa-peli\n Pelaajan 1 nimi: ");
			Player0 = Console.ReadLine();
			Console.Write("Pelaajan 2 nimi: ");
			Player1 = Console.ReadLine();

			Random DiceRandom = new Random();

			do
			{

				int i = 0;
				while (i <= 1)
				{
					int thisThrow = DiceRandom.Next(1, 6);
					DiceThrow0 +i += thisThrow;
					Console.ReadLine();
					Console.Write(Player0+i + " rolled a " + thisThrow);
					if (thisThrow != 6) i++;
				}

				Console.ReadLine();
				PlayerTotal0 += DiceThrow0;
				PlayerTotal1 += DiceThrow1;


				Console.ReadLine();
				Console.Write(Player0 + " currently has " + PlayerTotal0);
				Console.ReadLine();
				Console.Write(Player1 + " currently has " + PlayerTotal1);
				Console.ReadLine();

			}
			while (PlayerTotal0 < 20 && PlayerTotal1 < 20);
		}
	}
}
