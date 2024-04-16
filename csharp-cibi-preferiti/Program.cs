using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creo e inizializzo mio array di elementi
            string[] MioArray = { "pizza", "mandarino", "cicoria", "tonno", "bistecca di manzo", "peperone", "carota", "mela" };

            //Stampo l'unghezza effettiva array
            Console.WriteLine($"\nLa Lunghezza dell'array è: {MioArray.Length}\n");

            //Scorro tutto l'array ed estraggo le informazioni per ogni posizione
            for (int i = 0; i < MioArray.Length; i++)
            {
                //per ogni posizione dell'array stampo il valore corrispondente
                Console.WriteLine($"Il valore in posizione {i} è: {MioArray[i]}\n");
            }

            //Stampo il valore in posizione 0
            Console.WriteLine($"\nIl valore in posizione 0 è: {MioArray[0]}\n");

            //Stampo il valore in ultima posizoione
            Console.WriteLine($"\nIl valore in ultima posizione è: {MioArray[MioArray.Length - 1]}\n");

            //ottengo indice medio del mio array
            int val = MioArray.Length / 2;

            //Se questo indice è pari
            if (val % 2 == 0)
            {
                //Stampo il valore corrispondente
                Console.WriteLine($"\nL'elemento centrale sarà: {MioArray[val]}\n");
            }

            //altrimenti
            else
            {
                //Stampo il valore corrispondente e il precedente
                Console.WriteLine($"\nGli elementi centrale saranno: {MioArray[val - 1]} e {MioArray[val]} \n");
            }

            Console.ReadKey();
        }
    }
}
