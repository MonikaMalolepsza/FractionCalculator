
//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        ReduceToCommonDenominator.cs
//Datum:        22.06.2020
//Beschreibung:
//Aenderungen:  22.06.2020 Setup


namespace Fraction_Calculator
{
    partial class main
    {
        static void ReduceToCommonDenominator(ref Fraction fraction1, ref Fraction fraction2)
        {
            int commonMultiple = FindLeastCommonMultiple(fraction1.denominator, fraction2.denominator);
            fraction1.numerator *= commonMultiple / fraction1.denominator;
            fraction2.numerator *= commonMultiple / fraction2.denominator;
            fraction1.denominator = commonMultiple;
            fraction2.denominator = commonMultiple;
        }

    }
}