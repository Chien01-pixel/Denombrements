using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9bis_seance2
{
    class Program
    {
        /// <summary>
        /// Valeur absolue d'un nombre donné
        /// </summary>
        /// <param name="n">valeur donnée</param>
        /// <param name="result">valeur absolue du nombre donné</param>
        static void abs(int n, ref int result)
        {
            if ( n < 0)
            {
                result = -n;
            }
            else
            {
                result = n;
            }
        }
        static void Main(string[] args)
        {
            // Saisie d'un entier
            Console.Write("Entrez un nombre entier = ");
            int nombre = int.Parse(Console.ReadLine());

            // Récupération de la valeur absolue
            int absNombre = 0;
            abs(nombre, ref absNombre);

            // Affichage de la valeur absolue
            Console.WriteLine("La valeur absolue de " + nombre + " est " + absNombre);
            Console.ReadLine();
        }
    }
}
