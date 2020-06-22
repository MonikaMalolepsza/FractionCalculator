//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Subtraction.cs
//Datum:        22.06.2020
//Beschreibung:
//Aenderungen:  22.06.2020 Setup


namespace Fraction_Calculator
{
    partial class main
    {

        static void Subtraction(ref Fraction fraction1, ref Fraction fraction2, ref Fraction result)
        {
            ReduceToCommonDenominator(ref fraction1, ref fraction2);
            result.numerator = fraction1.numerator - fraction2.numerator;
            result.denominator = fraction1.denominator;
        }

    }
}