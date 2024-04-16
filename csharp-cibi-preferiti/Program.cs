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

            string[] MioArray = { "pizza", "mandarino", "cicoria", "tonno", "bistecca di manzo", "peperone", "carota", "mela" };

            Console.WriteLine($"\nLa Lunghezza dell'array è: {MioArray.Length}\n");

            //Scorro tutto l'array e estraggo le informazioni per ogni posizione
            for (int i = 0; i < MioArray.Length; i++)
            {
                Console.WriteLine($"Il valore in posizione {i} è: {MioArray[i]}\n");
            }


            Console.WriteLine($"\nIl valore in posizione 0 è: {MioArray[0]}\n");

            Console.WriteLine($"\nIl valore in ultima posizione è: {MioArray[MioArray.Length - 1]}\n");


            int val = MioArray.Length / 2;

            if (val % 2 == 0)
            {
                Console.WriteLine($"\nL'elemento centrale{val} sarà: {MioArray[val]}\n");
            }

            else
            {
                Console.WriteLine($"\nGli elementi centrale saranno: {MioArray[val - 1]} e {MioArray[val]} \n");
            }



            Console.ReadKey();
        }
    }
}
