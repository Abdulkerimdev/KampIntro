using System;

namespace Gun3Odevleri
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = RefOutKullanım.Add(71, 81);
            Console.WriteLine(result);

            int num1 = 5, num2 = 10;
            var res2 = RefOutKullanım.Add2(num1=0, num2=0);
            Console.WriteLine(num1 + " + " + num2 + " işleminin sonucu: " + res2);
            Console.WriteLine("main metottaki num1 değeri: " + num1);

            Console.WriteLine("\n----------------------\n");
            Console.WriteLine("Metot Overloading ");
            Console.WriteLine(MethodOverloading.Multiply(5,8));
            Console.WriteLine(MethodOverloading.Multiply(8,5,5));

            Console.WriteLine("\n----------------------\n");
            Console.WriteLine("Params");
            Console.WriteLine(Params.Add(1,2,3,4,9,9,9));
        }
        
    }
}
