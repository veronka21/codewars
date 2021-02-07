using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars
{
    class IntegersRecreationOne
    {

        public static string listSquared(long m, long n)
        {
            var result = new StringBuilder("[");
            for (long j = m; j <= n; j++)
            {
                var divisors = findDivisors(j);
                var sumOfSquares = getSumOfSquares(divisors);
                if (Math.Sqrt(sumOfSquares) % 1 == 0) result.Append($"[{j}, {sumOfSquares}], ");
            }
            var resultLength = result.ToString().Length;
            if (resultLength != 1) return $"{result.ToString(0, resultLength - 2)}]";
            else return "[]";

        }

        public static List<long> findDivisors(long number)
        {
            var divisors = new List<long>();
            for (long i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    if (!divisors.Contains(i))
                    {
                        divisors.Add(i);
                        if (!divisors.Contains(number / i)) divisors.Add(number / i);
                    } else
                    {
                        break;
                    }
                }
            }
            return divisors;
        }

        public static long getSumOfSquares(List<long> divisors)
        {
            return divisors.Select(number => number * number).Sum();
        }
    }
}
