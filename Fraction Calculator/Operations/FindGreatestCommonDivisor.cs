namespace Fraction_Calculator
{
    partial class main
    {

        public static int FindGreatestCommonDivisor(int number1, int number2)
        {
            int temp = 0;
            while (number1 % number2 != 0)
            {
                temp = number1 % number2;
                number1 = number2;
                number2 = temp;
            }

            return number2;
        }
    }
}