using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TrainProject1
{
    class FindPoint
    {


        static void Main(string[] args)
        {
           // TextWriter textWriter = new StreamWriter(@System.Console.Out.WriteLine(),true);
            int n = Convert.ToInt32(Console.ReadLine());

            for (int nItr = 0; nItr < n; nItr++)
            {
                string[] pxPyQxQy = Console.ReadLine().Split(' ');
                int px = Convert.ToInt32(pxPyQxQy[0]);
                int py = Convert.ToInt32(pxPyQxQy[1]);
                int qx = Convert.ToInt32(pxPyQxQy[2]);
                int qy = Convert.ToInt32(pxPyQxQy[3]);

                int[] result = findPoint(px, py, qx, qy);

                // textWriter.WriteLine(string.Join(" ", result));
                System.Console.Out.WriteLine(string.Join(" ", result));
            }
            System.Console.ReadLine();

            //textWriter.Flush();
            //textWriter.Close();

        }

        private static int[] findPoint(int px, int py, int qx, int qy)
        {
            int[] rxRy = { 0, 0 };
            int dx, dy;
            if (px > qx)
            {
                dx = px - qx;
                rxRy[0] = (0 - dx) + qx;
            }
            else if (px < qx)
            {
                dx = qx - px;
                rxRy[0] = (0 + dx) + qx;
            }
            else if (px == qx)
                rxRy[0] = px;
            if (py > qy)
            {
                dy = py - qy;
                rxRy[1] = (0 - dy) + qy;
            }
            else if (py < qy)
            {
                dy = qy - py;
                rxRy[1] = (0 + dy) + qy;
            }
            else if (py == qy)
                rxRy[1] = py;
            return rxRy;
            
            throw new NotImplementedException();
        }
    }
}
