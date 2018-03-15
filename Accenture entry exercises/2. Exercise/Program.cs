using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
			Encode("apple");
			Encode("apple alarm");
			Encode("zoo");
			Console.Read();

		}

		public static string Encode(string text)
        {
			string encodedText = "";
			string abc = "abcdefghijklmnopqrstuvwxyz";

			text = text.ToLower();

			char[] characters = text.ToCharArray();

			int shift = text.Count(c => c == characters[0]);

			foreach (char character in characters)
			{
				int index = abc.IndexOf(character);

				if (index == -1)
				{
					encodedText += character;
				}
				else
				{
					int encodedIndex = index + shift;

					if (encodedIndex > 25)
					{
						encodedIndex -= 26;
					}
					encodedText += abc[encodedIndex];
				}

			}

			Console.WriteLine("Input: " + text);
			Console.WriteLine("Output: " + encodedText);
			Console.WriteLine();

			return encodedText;

        }
    }
}
