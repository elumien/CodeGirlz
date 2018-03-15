using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Exercise
{
	class Deck
	{
		public Card[] cards;
		int clubs = 0;
		int diamonds = 0;
		int hearts = 0;
		int spades = 0;
		public string deckName;
		public string drawnCard;

		public Deck(int number)
		{

			if (number < 53)
			{
				cards = new Card[number];

				for (int i = 0; i < number; i++)
				{
					int color = i % 4;
					int value = i / 4;
					Card c = new Card(color, value);

					cards[i] = c;

					switch (color)
					{
						case 0:
							clubs++;
							break;
						case 1:
							diamonds++;
							break;
						case 2:
							hearts++;
							break;
						case 3:
							spades++;
							break;
					}

				}

				deckName = number + " cards - " + clubs + " Clubs, " +diamonds+" Diamonds, "+ hearts +" Hearts, "+spades+" Spades";
			}
			else
			{
				deckName = "Invalid Deck";
			}

		}

		public void Shuffle()
		{

			int n = cards.GetLength(0);

			Random rnd = new Random();

			for (int i = 0; i < n; i++)
			{
				Swap(i, i + rnd.Next(n-i));
			}

		}

		public void Swap(int a, int b)
		{
			Card temp = cards[a];
			cards[a] = cards[b];
			cards[b] = temp;
		}

		public void Draw()
		{
			drawnCard = cards[0].cardName;

			switch (cards[0].color)
			{
				case "Clubs":
					clubs--;
					break;
				case "Diamonds":
					diamonds--;
					break;
				case "Hearts":
					hearts--;
					break;
				case "Spades":
					spades--;
					break;
			}

			var cardList = new List<Card>(cards);
			cardList.RemoveAt(0);
			cards = cardList.ToArray();

			deckName = cards.GetLength(0) + " cards - " + clubs + " Clubs, " + diamonds + " Diamonds, " + hearts + " Hearts, " + spades + " Spades";

		}
	}
}
