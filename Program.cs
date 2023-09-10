using System;
using System.Reflection;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            int solution = Problem6.Solve();
            Console.WriteLine("The solution is :" + solution);

        }
    }

    class Problem2
    {
        public static int Solve()
        {
            int fibStart = 1;
            int fibNext = 2;
            int fibTemp;

            int evenSum = 0;

            while (fibNext <= 4000000)
            {
                fibTemp = fibStart + fibNext;

                if (fibNext % 2 == 0)
                {
                    evenSum += fibNext;
                }
                fibStart = fibNext;
                fibNext = fibTemp;
            }

            return evenSum;
        }
    }

    class Problem3
    {
        public static long Solve()
        {
            long num = 600851475143;
            List<long> factors = new();
            long i = 2;


            while (i < num)
            {
                if (num % i == 0)
                {
                    factors.Add(i);
                    num /= i;
                    i = 2;
                }
                else if (Math.IsPrime(num))
                {
                    if (num >= factors.Last())
                        return num;
                }
                i++;
            }

            factors = GetPrimes(factors);

            return factors.Last();
        }

        private static List<long> GetPrimes(List<long> factors)
        {
            List<long> primes = new();

            foreach (long factor in factors)
            {
                if (Math.IsPrime(factor) == true)
                {
                    primes.Add(factor);
                }
            }

            return primes;
        }
    }

    class Problem4
    {
        static public int Solve()
        {
            int product;
            string productString;
            int palindromeMax = 0;

            for (int i = 999; i > 100; i--)
            {
                for (int j = 999; j >= i; j--)
                {
                    product = i * j;
                    productString = Convert.ToString(i * j);
                    string reverseProduct = new string(productString.ToCharArray().Reverse().ToArray());
                    if (productString == reverseProduct)
                    {
                        if (product > palindromeMax)
                        {
                            palindromeMax = product;
                        }
                    }
                }
            }
            return palindromeMax;
        }
    }

    class Problem5
    {
        public static uint Solve()
        {
            uint num = 20;
            while (true)
            {
                for (uint i = 2; i <= 20; i++)
                {
                    if (num % i != 0)
                    {
                        break;
                    }
                    else if (i == 20)
                    {
                        return num;
                    }
                }
                num += 20;
            }
        }
    }

    class Problem6
    {
        static public int Solve()
        {
            int sumOfSpuares = 0;
            int squareOfSum = 0;

            for (int i = 1; i <= 100; i++)
            {
                squareOfSum += i;
                sumOfSpuares += Math.Power(i, 2);
            }
            squareOfSum = Math.Power(squareOfSum, 2);
            return squareOfSum - sumOfSpuares;
        }
    }

    // Class for common math functions I might use in the future.
    class Math
    {
        public static bool IsPrime(long num, long divisor = 2)
        {
            if (num < 2)
            {
                return false;
            }
            if (num == 2 || num == 3)
            {
                return true;
            }
            if (num % divisor == 0)
            {
                return false;
            }
            if (divisor * divisor > num)
            {
                return true;
            }
            bool result = IsPrime(num, divisor + 1);

            return (result);
        }

        public static int Power(int number, int exponet)
        {
            if (exponet == 0)
            {
                return 1;
            }
            int counter = 1;
            int power = number;
            while (counter < exponet)
            {
                number *= power;
                counter++;
            }
            return number;
        }
    }

}
