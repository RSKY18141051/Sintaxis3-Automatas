using System;

namespace Sintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (Lenguaje l = new Lenguaje("C:\\Archivos\\Suma.c"))
                {
                    /*while (!l.FinDeArchivo())
                    {
                        l.NextToken();
                    }
                    l.match("#");
                    l.match("include");
                    l.match("<");
                    l.match(Token.clasificaciones.identificador);
                    l.match(".");
                    l.match("h");
                    l.match(">");*/
                    l.Programa();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
