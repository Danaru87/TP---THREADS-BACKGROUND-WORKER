using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THREADS___BACKGROUND_WORKER
{
    class Program
    {
        static double[] tableau;
        static void Main(string[] args)
        {
            tableau = new double[10];
            Random r = new Random((int)DateTime.Now.Ticks);
            for (int i =0; i < 10; i++)
            {
                tableau[i] = r.NextDouble() * 10;
            }
            Afficher(tableau);
            Console.ReadLine();
            TriSelectionPermutation(tableau);
            Afficher(tableau);
            Console.ReadLine();

            tableau = new double[10000];
            r = new Random((int)DateTime.Now.Ticks * 5);
            for (int i = 0; i < 10000; i++)
            {
                tableau[i] = r.NextDouble() * 100;
            }
            Afficher(tableau);
            Console.ReadLine();
            TriSelectionPermutation(tableau);
            Afficher(tableau);

            Console.ReadLine();
        }

        static void TriSelectionPermutation(double[] tableau)
        {
            int i, iRech, iMin;
            double tmp;
            int N = tableau.Length;
            for (i = 0; i < N; i++)
            {
                for (iRech = iMin = i; iRech < N; iRech++)
                    if (tableau[iRech] < tableau[iMin])
                        iMin = iRech;
                if (iMin != i)
                {
                    tmp = tableau[iMin];
                    tableau[iMin] = tableau[i];
                    tableau[i] = tmp;
                }
            }
        }

        public static void Afficher(double[] tableau)
        {
            for (int i = 0; i < tableau.Length; i++)
                Console.WriteLine("T[{0}] = {1}", i, tableau[i]);
        }
    }
}
