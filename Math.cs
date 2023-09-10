// Class for common math functions I might use in the future.

namespace ProjectEuler
{
    public static class Math
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
    
        public static int Power(int number, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }
            var counter = 1;
            var power = number;
            while (counter < exponent)
            {
                number *= power;
                counter++;
            }
            return number;
        }
    }
}