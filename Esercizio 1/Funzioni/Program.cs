using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funzioni
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool ind = false;
            char risp;

            do
            {
                n = generaNumero();
                for (int i = 0; i < 10; i++)
                {
                    ind = indovinaNumero(n);
                    if (ind == true)
                    {
                        break;
                    }

                    //if (indovinaNumero(n)) break;
                }

                if (ind == false)
                {
                    Console.WriteLine("HAI FINITO I TENTATIVI (IL NUMERO ERA: " + n + ")");
                }

                Console.WriteLine("NUOVA PARTITA? (s/n)");
                risp = Console.ReadKey().KeyChar;

                Console.Clear();
            }
            while (risp == 's');
        }

        public static int generaNumero()
        {
            Random r = new Random();
            int x = r.Next(1000, 10000);
            return x;
            
            /*
                Random r = new Random();
                return r.Next(1000, 10000);
            */
        }
        
        public static bool indovinaNumero(int x)
        {
            bool trovato = false;

            Console.WriteLine("INSERISCI IL NUMERO DA INDOVINARE");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a < x)
            {
                Console.WriteLine("IL NUMERO INSERITO E' TROPPO PICCOLO");
            }
            else if (a > x)
            {
                Console.WriteLine("IL NUMERO INSERITO E' TROPPO GRANDE");
            }
            else
            {
                Console.WriteLine("HAI INDOVINATO IL NUMERO"); trovato = true;
            }

            return trovato;
        }
    }
}
