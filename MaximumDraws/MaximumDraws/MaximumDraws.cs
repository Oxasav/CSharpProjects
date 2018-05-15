using System;

namespace MaximumDraws
{
    class MaximumDraws
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("MaximumDraws Draws: Enter number of test cases and nuber of sox pairs for each test case");
            maximumDrawsOutput();
            Console.Out.WriteLine("Number of hand shakes: Enter number of test cases and nuber of people test case");
            handShackOutput();

            Console.ReadLine();
        }


        private static void maximumDrawsOutput()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            if (t < 1 || t > 1000)
            {
                Console.Out.WriteLine("Inapropriate number of test cases");
                Console.ReadLine();
            }
            else
            {

                for (int tItr = 0; tItr < t; tItr++)
                {
                    int n = Convert.ToInt32(Console.ReadLine());

                    if (n <= 0 && n > Math.Pow(10, 6))
                    {
                        Console.Out.WriteLine("Inapropriate number of test cases");
                    }
                    else
                    {
                        int result = maximumDraws(n);

                        Console.Out.WriteLine(result);
                    }
                }

                Console.ReadLine();
            }
        }

        private static int maximumDraws(int n)
        {
            return n + 1;
        }

        private static void handShackOutput()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = handshake(n);

                Console.Out.WriteLine(result);
            }
        }

        private static int handshake(int n)
        {
            if (n >= 0)
                return ((n - 1) * (n)) / 2;
            else
                return 0;
           // throw new NotImplementedException();
        }
    }
}

