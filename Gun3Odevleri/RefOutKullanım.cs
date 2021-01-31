using System;
using System.Collections.Generic;
using System.Text;

namespace Gun3Odevleri
{
    class RefOutKullanım
    {
        public static int Add(int num1 = 0, int num2 = 0)//default değerler olarak 0,0 verildi.
        {
            var result = num1 + num2;
            return result;
        }

        public static int Add2(int num1, int num2)
        {
            /*Soru: Buraya Add2(num1=5,num2=10) olarak gönderilen değerlerle bu fonksiyon
             * ne döndürür? Ayrıca ana metottaki num1 değişkeni, bu metot çağırıldıktan  
             * bu metottaki 30 değerini mi yazdırır yoksa 5 değerini mi yazdırır?
             * 
             * Cevap: Cevap 40'dır çünkü num1 aşağıda 30 tanımlanmış ve toplamada num1 i
             * alıyor bu kolay. Ana metottaki num1 değeri ise hala 5 olarak kalıyor. Çünkü
             * buraya num1 in referansını gönderip bu referansın değerini 30 a dönüştürmüyor.
             * Buraya bir değer tip geliyor. Bu metotta değişkenin yalnızca değeri gidiyor.
             * İsimlerinin aynı olması bir şeyi değiştirmiyor. 
             * Kısaca Add2(5,10) göndermekle Add2(num1,num2) arasında bir fark yok. Return
             * değerinin farklı olmasının sebebi ise, metotta toplama olarak 30 değerinin
             * işlemde kullanılması
             */
            num1 = 30;
            var result = num1 + num2;
            return result;
        }
        /*Eğer ana metottaki değerin değişmesi için yani referansının gönderilmesi için 
         * metot şöyle;
         * static int Add2(ref num1, ref num2) 
         * çağırma böyle;
         * var res = Add(ref num1, ref num2) 
         * yazılmalıdır. 
         */

        /*Ref ve out parametrelerini her biri birbirinden farklı olan ve markette raflara 
         * kusursuzca yerleştirilen kavanozlar olarak düşünebiliriz. Yukarıdaki işlemleri 
         * ref ya da out kullanmadan yaptığımızda biz sadece kavanozu kavanoz1 kavanoz2 
         * olarak kullanıyoruz diyebiliriz. Yani içindeki şey dışında kavanoz1 ve kavanoz3
         * tamamen aynı çünkü içerisi yani asıl kullanılacak şey belli değil. Sadece bir 
         * değer verdik. Fakat ref ve out ile biz 'şu raftaki şu ürün' diye belirtip onu
         * kullanıyoruz.
         */

        /*Ref ve out farkı ise,
         * out kullanırken başta değerini ayarlamak zorunda değilsin. Fakat gönderdiğin 
         * yerde bir değer ayarlamalısın.
         * ref kullanırken başta bir değer ayarlamak zorundasın. Fakat gönderdiğin yerde 
         * bir değer ayarlamak zorunda değilsin.
         */
    }
}
