using System;
using static Datatyper.Datatyp;

namespace Datatyper
{
    class Datatyper
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Detta är ett program som kollar vilken datatyp som matas in!");

            Datatyp Dtyp = new Datatyp();

            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Skriv Q för att avsluta! ");
                Console.Write("Mata in något för att ta reda på dess datatyp: ");

                if (input == "Q" || input == "q")
                {
                    break;
                }

                Dtyp.Data();

                Console.WriteLine($"'{input}'Detta är datatypen " + svar);
            }
        }
    }
}
