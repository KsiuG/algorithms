using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypesAlgorithms
{
   public   class MaxPairWise
    {
        public static long MaxValue (List<int> data)
        {
            // var inputCount = Console.ReadLine();
            var number = data.Count(); //int.Parse(inputCount);
            var n = 0;
            //var input = Console.ReadLine();
            //var tokens = input.Split(' ');

            var element = data[n];
            var high = element;
            var secHigh = element;
            var secHighIndex = n;
            var highIndex = n;
            n = 1;
            while (n < number)
            {
                var a = data[n];

                if (a > high)
                {
                    high = a;
                    highIndex = n;

                    if (data[n - 1] > secHigh)
                    {
                        secHigh = data[n - 1];
                        secHighIndex = n - 1;
                    }
                }
                else if (a > secHigh)
                {
                    secHigh = a;
                    secHighIndex = n;
                }
                n = n + 1;
            }
            long highL = Convert.ToInt64(high);
            long secHighL = Convert.ToInt64(secHigh);
            long result = highL * secHighL;
            return result; 
        }
    }
}
