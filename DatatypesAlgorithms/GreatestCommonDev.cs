using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypesAlgorithms
{
    class GreatestCommonDev
    {
        

        public static double ComputeDev (long first , long second)
        {
            double devider;
            long a = 0;
            long b = 0;

            if (first > second)
            {
                devider = second;
                a = first;
                b = second;

                if (second == 0)
                {
                    devider = first;
                }
            }
            else if (second > first)
            {
                devider = first;
                a = second;
                b = first;

                if (first == 0)
                {
                    devider = second;
                }
            }
            else
            {
                devider = first;
            }

            //var n = first % devider;
            //var m = second % devider;

            while (a%devider != 0 || b%devider != 0)
            {
                //do
                //{
                //    devider = devider - 1;
                //}
                //while (first % devider != 0);

               devider =  deviderPrime(a,b); 
            }

            return devider;
        }

        static double  deviderPrime(long a, long b)
        {
            double devPrime = -1;
            while (b > 0)
            {
                long n;
                long reminder;
                
                n = a / b;
                reminder = a - b * n;
                a = b;
                b = reminder;
                devPrime = a; 
            }
            return devPrime; 
        }
    }
}
