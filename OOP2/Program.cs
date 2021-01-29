using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //kerim dev
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123";
            musteri1.Adi = "Kerim";
            musteri1.Soyadi = "Dev";
            musteri1.TcNo = "12345678901";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "5";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "11111";

            //solid prensip
            Musteri musteri3 = new GercekMusteri() { Id = 3, Adi = "Selami", Soyadi = "büyükbakan", MusteriNo = "846", TcNo = "5555555" };
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
        }
    }
}
