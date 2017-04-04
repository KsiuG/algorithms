using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypesAlgorithms
{

    class Program
    {

        static void Main(string[] args)
        {
          
            //var data = Enumerable.Range(0, 100000).ToList();
            List<int> data = new List<int>();
            //data.Add(68165);
            //data.Add(30342);
            //data.Add(87637);
            //data.Add(74297);
            //data.Add(2904);
            //data.Add(32873);
            //data.Add(86010);
            //data.Add(87637);
            //data.Add(66131);
            //data.Add(82858);
            //data.Add(82935);

            //data.Add(2);
            //data.Add(9);
            //data.Add(3);
            //data.Add(1);
            //data.Add(9);



            //var result = MaxPairWise.MaxValue(data);
            //Console.WriteLine(result);   

            // decimal result = Fibonacci.GetFibNum(100);

            var result = GreatestCommonDev.ComputeDev(357,234);
            Console.WriteLine(result);
         }
    }


}


