using System;
using System.Collections.Generic;

namespace summation 
{
    class summationPrimes
    {
        public static void Main(string[] args)
        {
            int min = 2000000;
            List<int> primes = new List<int>();
            int num = 0;
            int sum = 0;
            for(int x=2; x<=min; x++)
            {
                for(int y=2; y<=x; y++)
                {
                    if(y==x)
                    {
                        primes.Add(x);
                        num = num+1;
                        break;
                    }
                    else if(x%y!=0)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                num = 0;
                Console.WriteLine(x);
            }
            foreach(var prime in primes)
            {
                // Console.WriteLine(prime);
                sum = sum + prime;
            }
            Console.WriteLine(sum);
        }
    }
}