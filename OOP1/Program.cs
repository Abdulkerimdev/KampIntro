using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 25;

            //yukarıdaki nesne tanımı aşağıdaki şekilde de yapılabilir.
            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitsInStock = 5,
                ProductName = "kalem",
                UnitPrice = 25
            };
            /*[EN]Pascal case: first letter of each word is capital for instance: NewProject
             * Camel case: first letter of each word is capital EXCEPT first word for instance: newProjectFileAdder
             * Case sensivity: ability to distinguish uppercase and lowercase. If something is able to recognize as a different
             * name for between uppercase and lowercase than this thing has a case sensivity
             *Pascal case: Her kelimenin ilk harfi büyük örneğin: YeniProje
             * Camel case: İlk kelime dışında her kelimenin ilk harfi büyük örneğin: yeniProjeDosyaEkleyici
             * Case sensivity: Büyük harf ve küçük harf arasındaki farkı ayırt edebilme. Herhangi bi şey, büyük harf ve 
             * küçük harfi farklı isim olarak tanıyabilirse bu şeyin harf duyarlılığı(case sensitivity) vardır. 
            */
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            }
    }
}
