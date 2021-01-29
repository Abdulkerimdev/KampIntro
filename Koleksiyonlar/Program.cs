using System;

using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "engin", "kerim", "kemal" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            //isimler[4] = "musa" bu hata verir çünkü array oluştuğunda sınırları belirlenmiş olur bu sınırın dışına çıkar


            /* isimler[]= new string[5]
             * isimler[4] = "sami"
             * yukarıda yeniden tanımlama da hata olluşturur çünkü
             * diziyi yeniden tanımladığımız için diğer elemanlar gider
             */

            List<string> efsaneMilan = new List<string> {"Dida","Cafu","Maldini","shevchenko","gattuso","crespo",
            "nesta","seedorf","pirlo","kaka", "stam"};
            //using System.Collections.Generic kullanmak gerek yukarıdaki List için
            efsaneMilan.Add("Mesut Özil xD ");




        }
    }
}
