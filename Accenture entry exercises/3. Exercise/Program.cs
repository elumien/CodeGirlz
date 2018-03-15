using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			Deck d = new Deck(1);
			Console.WriteLine(d.deckName);
			d.Shuffle();
			d.Draw();
			d.Draw();
			Console.WriteLine(d.drawnCard);
			Console.WriteLine(d.deckName);
			Console.Read();

		}
	}
}
