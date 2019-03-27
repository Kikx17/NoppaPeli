using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoppaPeli
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				do
				{
					string syote;
					Sovellus.Aja();

					Console.Write("Paina Enter lopettaaksesi...");
					syote = Console.ReadLine();
					if (syote.Length == 0)
					{
						break;
					}
				} while (true);

			}
			catch (Exception e)
			{
				Console.WriteLine("Ohjelman suoritus päättyi virheeseen.\n Virhe: ", e);
			}
		}
	}
}
