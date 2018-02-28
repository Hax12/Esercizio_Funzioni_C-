using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es3
{
    class Program
    {
        //******MAIN PROGRAM******//

        static void Main(string[] args)
        {
            int Numero = 0;
            double area;
            switch (scelta(Numero))
            {
                case 1: area = areaQuadrato(); break;
                case 2: area = areaCerchio(); break;
                default: Console.WriteLine("IL NUMERO INSERITO NON è VALIDO"); break;
            }
            Console.ReadKey();
        }

        //******FUNZIONI******//

        static double areaQuadrato()
        {
            double Lato, Area;
            Console.WriteLine("INSERISCI IL VALORE DEL LATO");
            Lato = Convert.ToDouble(Console.ReadLine());
            if (Lato <= 0)
            {
                Console.WriteLine("ERRORE LATO NON VALIDO");

            }
            Area = Lato * Lato;
            Console.WriteLine("L'AREA E' DI.." + Area);
            return Area;
        }

        static double areaCerchio()
        {
            int Raggio;
            double area;
            const double PI = 3.14;
            Console.WriteLine("INSERISCI IL VALORE DEL RAGGIO");
            Raggio = Convert.ToInt32(Console.ReadLine());
            if (Raggio <= 0)
            {
                Console.WriteLine("ERRORE RAGGIO NON VALIDO");
            }

            area = Raggio * Raggio * PI;
            Console.WriteLine("L'AREA E' DI.." + area);
            return area;
        }

        static int scelta(int Numero)
        {
            Console.WriteLine("PREMI 1 SE VUOI CALCOLARE L'AREA DI UN QUADRATO, PREMI 2 SE VUOI CALCOLARE L'AREA DI UN CERCHIO");
            Numero = Convert.ToInt32(Console.ReadLine());
            return Numero;
        }
    }
}
