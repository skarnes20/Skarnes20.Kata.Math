using System.Collections.Generic;

namespace Skarnes20.Kata.Math
{
    public class Primfactors
    {
        public static IEnumerable<int> Of(int number)
        {
            var primefactors = new List<int>();
            for (var factor = 2; factor <=  System.Math.Sqrt(number); factor++)
            {
                while (number % factor == 0)
                {
                    primefactors.Add(factor);
                    number /= factor;
                }
            }

            if (number > 1)
            {
                primefactors.Add(number);
            }

            return primefactors;
        }

        public static IEnumerable<int> Factors(int number)
        {
            for (var factor = 2; factor < number; factor++)
            {
                while (number % factor == 0)
                {
                    number /= factor;
                    yield return factor;
                }
            }

            if (number > 1)
                yield return number;
        }
    }
}