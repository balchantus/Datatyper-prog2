using System;

namespace Datatyper
{
    class Datatyp
    {
        public static string[] typ = { "integer", "float", "bool", "char", "string" };
        public static string svar = " ";
        public static string input = " ";

        public string Data()
        {
            input = Console.ReadLine();

            if (Int32.TryParse(input, out _))
            {
                svar = typ[0];
                return svar;
            }

            else if (float.TryParse(input, out _))
            {
                svar = typ[1];
                return svar;
            }

            else if (bool.TryParse(input, out _))
            {
                svar = typ[2];
                return svar;
            }

            else if (char.TryParse(input, out _))
            {
                svar = typ[3];
                return svar;
            }

            else
            {
                svar = typ[4];
                return svar;
            }
        }
    }
}
