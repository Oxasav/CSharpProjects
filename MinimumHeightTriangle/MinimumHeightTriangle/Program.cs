using System;

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
