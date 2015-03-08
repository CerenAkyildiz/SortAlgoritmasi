using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 64, 72, 205, 46, 6, 10, 2, 6, 3, 5, 0, 7, 2, 80, 13 };
            int istenenEleman;
            Console.WriteLine("Sıralanmamış Dizi :");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("Sıralanmış Dizi :");
            Sort(a);

            Console.WriteLine(" ");

            Console.Write("Kaçıncı Eleman : ");
            istenenEleman = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ElamanBul(istenenEleman, a));
        }
        public static void Sort(int[] dizi)
        {
            int gecici = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = 0; j < dizi.Length; j++)
                {
                    if (dizi[i] < dizi[j])
                    {
                        gecici = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = gecici;

                    }
                }

            }
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + " ");
            }
            Console.WriteLine(" ");


        }
        public static int ElamanBul(int k, int[] dizi)
        {
            return dizi[k];
        }
    }
}