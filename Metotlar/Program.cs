using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double fiyat = 15;
            string aciklama = "yerli elma";

            string[] meyveler = new string[] {"elma", "karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "kereviz";
            urun2.Fiyati = 25;
            urun2.Aciklama = "ithal kereviz";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var x in urunler)
            {
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Fiyati);
                Console.WriteLine(x.Aciklama);
                Console.WriteLine("---------------------");
            }
            Console.WriteLine("------Metotlar------");
            //instance-örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            //aşağısı verimsiz çünkü stok gibi 4.değer girilmesi gerekirse
            //ekle2 metodu değişecek ve kullanıldığı her yere tek tek eklenmesi
            //gerekecek bu da sorun

            sepetManager.Ekle2("armut", "yeşil armut", 12.5,200);
            sepetManager.Ekle2("havuç", "normal havuç", 2.5, 150);
            sepetManager.Ekle2("mandalina", "güzeel mandaline", 2.5, 50);

        }
    }
}
