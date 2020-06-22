//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Division.cs
//Datum:        22.06.2020
//Beschreibung:
//Aenderungen:  22.06.2020 Setup


namespace Fraction_Calculator
{
    partial class main
    {
        static void Division(ref Fraction fraction1, ref Fraction fraction2, ref Fraction result)
        {
            result.numerator = fraction1.numerator * fraction2.denominator;
            result.denominator = fraction1.denominator * fraction2.numerator;
        }
    }
}