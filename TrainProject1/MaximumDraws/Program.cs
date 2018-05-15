using System;

namespace MaximumDraws
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = maximumDraws(n);

                System.Console.Out.WriteLine(result);
            }
        }

        private static int maximumDraws(int n)
        {
            return n + 1;
            //throw new NotImplementedException();
        }
    }
}
