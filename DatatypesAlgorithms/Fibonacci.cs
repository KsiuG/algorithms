using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypesAlgorithms
{
    public class Fibonacci
    {
        public static decimal GetFibNum(int num)
        {
            decimal result = 0;
            int n = 2;
            List <decimal> numbers = new List<decimal>();
            numbers.Add(0);
            numbers.Add(1);
            while (n <= num)
            {
                decimal number = numbers[n - 2] + numbers[n - 1]; 
                numbers.Add(number);
                result = number; 
                n = n + 1; 
                
            }

           
           
            return  result; 
        }
    }
}
