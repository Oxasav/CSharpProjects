using System;
using System.Globalization;

namespace MinimumHeightTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_base = Console.ReadLine().Split(' ');
            int baseTr = Convert.ToInt32(tokens_base[0]);
            int area = Convert.ToInt32(tokens_base[1]);
            int height = lowestTriangle(baseTr, area);
            Console.WriteLine(height);
            Console.ReadLine();


            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";
           
            // Declare second integer, double, and String variables.
            int iSecond;
            double dSecond;
            string sSecond;
            // Read and save an integer, double, and String to your variables.
            iSecond = int.Parse(Console.ReadLine());
            dSecond = double.Parse(Console.ReadLine());
            sSecond = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + iSecond);

            // Print the sum of the double variables on a new line.
            Console.WriteLine("{0:f1}", d + dSecond);

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s+sSecond);

            Console.ReadLine();
        }

        private static int lowestTriangle(int baseTr, int area)
        {
            double height = 0;
            height = (2 * Convert.ToDouble(area) )/ Convert.ToDouble(baseTr);
            if (height > Math.Round(height))
            {
                return Convert.ToInt32(Math.Round(height) + 1);
            }
            else
                return Convert.ToInt32(Math.Round(height));
        }
    }
}
