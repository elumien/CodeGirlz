using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accenture_entry_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: [1, 2, 3, 4, 5, 6]");

            int[] example1 = { 1, 2, 3, 4, 5, 6 };

            double average1 = OddAverage(example1);

            Console.WriteLine("Output: " + average1);

            Console.WriteLine();

            Console.WriteLine("Input: [-3, -2, -1, 0, 1, 2, 3, 5, 7]");

            int[] example2 = {-3, -2, -1, 0, 1, 2, 3, 5, 7};

            //int[] example2 = {1, 13, 7, 5, 32523};

            double average2 = OddAverage(example2);

            Console.WriteLine("Output: " + average2);

            Console.Read();
        }

        public static double OddAverage(int[] numbers)
        {
            double dividend = 0;
            double average = 0;
            double divisor = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 1 || number % 2 == - 1)
                {
                    dividend += number;
                    divisor++;
                }
            }

            average = dividend / divisor;

            return average;
            
        }
    }
}
