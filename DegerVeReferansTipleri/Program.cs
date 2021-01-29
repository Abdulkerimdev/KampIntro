using System;

namespace DegerVeReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30
            
            /*int, decimal, float, double, bool gibi değişkkenler değer tipli iken
             array, class, interface referans tiplerdir
            */
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] 999
            Console.WriteLine("sayi1: " + sayi1 + "\niken sayilar dizisi şöyledir:");
            foreach (int item in sayilar1)
            {
                Console.WriteLine(item);
            }


        }
    }
}