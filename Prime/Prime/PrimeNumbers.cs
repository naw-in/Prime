using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    public class PrimeNumbers : IPrimeNumbers
    {
        public List<int> GeneratePrimeNumbers(int number)
        {
            
            int i = 3, c;
            var primeNumbers = new List<int>();

            if (number >= 1)
            {
                primeNumbers.Add(2);
            }

            for (int count = 2; count <= number; )
            {
                for (c = 2; c <= i - 1; c++)
                {
                    if (i % c == 0)
                        break;
                }
                if (c == i)
                {
                    primeNumbers.Add(i);
                    count++;
                }
                i++;
            }
            return primeNumbers;
        }
    }
}
