using System;
using static System.Console;

namespace Es3
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Inserisci una parola: ");
            string parola = ReadLine().ToLower();

            int contatore = 0;
            bool a = false; 
            bool e = false; 
            bool i = false; 
            bool o = false; 
            bool u = false;

            for (int j = 0; j < parola.Length; j++)
            {
                char c = parola[j];

                if (c == 'a' && !a)
                {
                    contatore++;
                    a = true;
                }
                else if (c == 'e' && !e)
                {
                    contatore++;
                    e = true;
                }
                else if (c == 'i' && !i)
                {
                    contatore++;
                    i = true;
                }
                else if (c == 'o' && !o)
                {
                    contatore++;
                    o = true;
                }
                else if (c == 'u' && !u)
                {
                    contatore++;
                    u = true;
                }
            }

            if (contatore >= 4)
                WriteLine("Parola magica ");
            else
                WriteLine("Parola non magica");
        }
    }
}
