using System;
using static System.Console;

namespace Es4
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Inserisci numero: ");
            string n = ReadLine();

            bool sicura = true;

            for (int i = 1; i < n.Length - 1; i++)
            {
                if (!((n[i] > n[i - 1] && n[i] > n[i + 1]) ||
                      (n[i] < n[i - 1] && n[i] < n[i + 1])))
                {
                    sicura = false;
                    break;
                }
            }

            if (sicura)
                WriteLine("Strada sicura");
            else
                WriteLine("Strada NON sicura");
        }
    }
}
