using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTest
{
    public class Fraction
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public Fraction (int numerator = 0, int denominator = 1)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public Fraction Add(Fraction fraction)
        {
            int sumNumerator = (Numerator * fraction.Denominator) + (fraction.Numerator * Denominator);
            int sumDenominator = Denominator * fraction.Denominator;
            Fraction sum = new(sumNumerator, sumDenominator);

            return sum;
        }
    }
}
