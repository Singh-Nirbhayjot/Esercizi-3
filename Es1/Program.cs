using System;
using static System.Console;

namespace Es1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Write("Inserisci numero: ");
            int.TryParse(ReadLine(), out n);

            int somma = 0;
            int prodotto = 1;

            int temp = n;
            while (temp > 0)
            {
                int cifra = temp % 10;
                somma += cifra;
                prodotto *= cifra;
                temp /= 10;
            }

            if (somma % 3 == 0 && prodotto % 2 == 0)
                WriteLine("Codice valido");
            else
                WriteLine("Codice NON valido");
        }
    }
}
