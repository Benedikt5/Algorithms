using System;
using System.Numerics;

namespace Karatsuba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           
        }

        static long Multiply(BigInteger x, BigInteger y)
        {
            var lenX = GetLength(x);
            var lenY = GetLength(y);

            
        }

        static BigInteger GetLeft(BigInteger a)
        {
            var len = GetLength(a);
            var shift = (int)Math.Round((double)len / 2, MidpointRounding.AwayFromZero);
            return a >> shift;
        }

        static BigInteger GetBight(BigInteger a)
        {

        }

        static int GetLength(BigInteger num)
        {
            return (int)Math.Floor(BigInteger.Log10(num) + 1);
        }
    }
}
