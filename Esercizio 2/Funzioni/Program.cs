using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funzioni
{
    class Program
    {
        // Costanti 
        public const int GIORNI = 31, TEMP = 2;

        static void Main(string[] args)
        {
            // TemperatureMinime 0, TemperatureMassime 1
            float[,] temperature = new float[GIORNI, TEMP];
            bool uscita = false;

            inserimento(ref temperature);

            do
            {
                switch (menù())
                {
                    case 1: { Console.Clear(); visualizzaTemperature(temperature); break; }
                    case 2: { Console.Clear(); media(temperature); break; }
                    case 3: { Console.Clear(); differenzaTemperature(temperature); break; }
                    default: { uscita = true; break; }
                }
            }
            while (!uscita);
        }

        public static void inserimento(ref float[,] t)
        {
            for (int i = 0, g = 1; i < GIORNI; i++, g++)
            {
                Console.Write("Giorno " + g + ": (Temperatura Minima): ");
                t[i, 0] = float.Parse(Console.ReadLine());

                Console.Write("Giorno " + g + ": (Temperatura Massima): ");
                t[i, 1] = float.Parse(Console.ReadLine());
            }

            /*
                Random r = new Random();
                for (int i = 0; i < GIORNI; i++)
                {
                    t[i, 0] = r.Next(0, 50);
                    t[i, 1] = r.Next(50, 100);
                }
            */
        }

        public static int menù()
        {
            Console.Clear();
            Console.WriteLine("Menù delle temperature di Gennaio");
            Console.WriteLine("1) Visualizza elenco temperature");
            Console.WriteLine("2) Visualizza media temperature massime");
            Console.WriteLine("3) Visualizza differenza temperature");
            Console.WriteLine("4) Esci");
            Console.Write("Scegli Numero: ");

            return Convert.ToInt32(Console.ReadLine());
        }

        public static void visualizzaTemperature(float[,] t)
        {
            for (int i = 0, g = 1; i < GIORNI; i++, g++)
            {
                Console.WriteLine("Giorno " + g + ':');
                Console.WriteLine("Temperatura Minima: " + t[i, 0] + " | Temperatura Massima: " + t[i, 1]);
            }

            Console.ReadKey();
        }

        public static void media(float[,] t)
        {
            float somma = 0;

            for (int i = 0; i < GIORNI; i++)
            {
                somma += t[i, 1];
            }

            Console.WriteLine("La media delle temperature massime è: " + somma / GIORNI);
            Console.ReadKey();
        }

        public static void differenzaTemperature(float[,] t)
        {
            float diff = t[0, 1] - t[0, 0];
            int g = 1;

            for (int i = 1; i < GIORNI; i++)
            {
                if ((t[i, 1] - t[i, 0]) < diff)
                {
                    diff = t[i, 1] - t[i, 0];
                    g = i + 1;
                }
            }

            Console.WriteLine(
                "Il giorno " + g + " è stato quello con la differenza di temperatura minima (" + diff + ')'
            );
            Console.ReadKey();
        }
    }
}
