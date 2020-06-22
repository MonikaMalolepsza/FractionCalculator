namespace Fraction_Calculator
{
    partial class main
    {
        public static int FindLeastCommonMultiple(int number1, int number2)
        {
            int commonDivisor = FindGreatestCommonDivisor(number1, number2);
            int commonMultiple = number1 * number2 / commonDivisor;

            return commonMultiple;
        }
    }


}