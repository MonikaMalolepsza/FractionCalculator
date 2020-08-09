//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        run.cs
//Datum:        22.06.2020
//Beschreibung:
//Aenderungen:  22.06.2020 Setup


namespace Fraction_Calculator
{
    partial class main
    {
        static void Run()
        {
            Splashinfo();

            Fraction fraction1 = new Fraction();
            Fraction fraction2 = new Fraction();
            Fraction result = new Fraction();
            Menu(ref fraction1, ref fraction2, ref result);
        }

        struct Fraction
        {

            public int numerator;
            public int denominator;
        }
    }
}
