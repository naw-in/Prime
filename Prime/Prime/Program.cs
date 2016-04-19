using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrimeNumbers primeNumbers;
            primeNumbers = new PrimeNumbers();

            Console.WriteLine("Enter the number of prime numbers you want");
            int num = Convert.ToInt32(Console.ReadLine());

            var prime = primeNumbers.GeneratePrimeNumbers(num);
            Console.Write("\t");
            foreach (int p in prime)
            {
                Console.Write(p + "\t");
            }
            Console.Write("\n");
            foreach (int p in prime)
            {
                Console.Write(p + "\t");
                foreach (int n in prime)
                {
                    if (p > 0) Console.Write(p * n + "\t");
                    else Console.Write(n + "\t");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
