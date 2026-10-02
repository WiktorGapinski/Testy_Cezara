using System;

public class Program
{
    public static string SzyfrCezara(string tekst, int klucz)
    {
        string wynik = "";

        klucz = klucz % 26;

        for (int i = 0; i < tekst.Length; i++)
        {
            char znak = tekst[i];

            if (znak >= 'a' && znak <= 'z')
            {
                int kod = znak + klucz;

                if (kod > 122)
                {
                    kod = kod - 26;
                }

                if (kod < 97)
                {
                    kod = kod + 26;
                }

                wynik = wynik + (char)kod;
            }
            else
            {
                wynik = wynik + znak;
            }
        }

        return wynik;
    }

    static void Main()
    {
        Console.Write("Podaj tekst jawny: ");
        string tekst = Console.ReadLine();

        Console.Write("Podaj klucz: ");
        int klucz = int.Parse(Console.ReadLine());

        string wynik = SzyfrCezara(tekst, klucz);

        Console.WriteLine("Tekst zaszyfrowany: " + wynik);

        Console.ReadKey();
    }
}
