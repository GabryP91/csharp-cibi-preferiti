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
            string[] MioArray = { "pizza", "mandarino", "cicoria", "tonno", "bistecca di manzo", "peperone", "carota"};

            //Stampo l'unghezza effettiva array
            Console.WriteLine($"\n La Lunghezza dell'array è: {MioArray.Length}\n");

            //Scorro tutto l'array ed estraggo le informazioni per ogni posizione
            for (int i = 0; i < MioArray.Length; i++)
            {
                //per ogni posizione dell'array stampo il valore corrispondente
                Console.WriteLine($" Il valore in posizione {i+1} è: {MioArray[i]}\n");
            }

            //Stampo il valore in posizione 0
            Console.WriteLine($"\n Il valore in posizione 1 è: {MioArray[0]}\n");

            //Stampo il valore in ultima posizoione
            Console.WriteLine($"\n Il valore in ultima posizione è: {MioArray[MioArray.Length - 1]}\n");

            //ottengo indice medio del mio array
            int val = MioArray.Length / 2;

            //Se il mio array ha un lunghezza pari
            if (MioArray.Length % 2 == 0)
            {
                //Stampo il valore corrispondente e il precedente
                Console.WriteLine($"\n Gli elementi centrale saranno: {MioArray[val - 1]} e {MioArray[val]} \n");
                
            }

            //altrimenti
            else
            {
                //Stampo il valore corrispondente
                Console.WriteLine($"\n L'elemento centrale sarà: {MioArray[val]}\n");
            }

            Console.ReadKey();
        }
    }
}
