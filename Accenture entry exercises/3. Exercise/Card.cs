using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Exercise
{
	public class Card
	{
		public string color;
		public string value;
		public string cardName;

		string[] colors = {"Clubs", "Diamonds", "Hearts", "Spades"};
		string[] values = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

		public Card(int c, int v)
		{
			if (c<4 && v<13)
			{
				color = colors[c];
				value = values[v];
				cardName = value + " " + color;
			}
			else
			{
				cardName = "Invalid Card";
			}

		}
	}
}
