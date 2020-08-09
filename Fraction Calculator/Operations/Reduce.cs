namespace Fraction_Calculator
{
    partial class main
    {
        static void Reduce(ref Fraction fraction)
        {
            if (fraction.numerator != 0)
            {
                int gcd = FindGreatestCommonDivisor(fraction.denominator, fraction.numerator);
                fraction.numerator /= gcd;
                fraction.denominator /= gcd;
            }


        }

    }
}