using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] campo = new char[3, 3];
            inizializzazione(ref campo);
            do
            {
                turno(ref campo);

            }
            while (controlloVincita(campo));

            Console.ReadKey();
        }


        static void inizializzazione(ref char[,] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 0; j < c.Length; j++)
                {
                    c[i, j] = ' ';
                }
            }
        }

        static void turno(ref char[,] c)
        {

        }

        static bool controlloVincita(char[,] c)
        {

            return true;
        }


    }
}
