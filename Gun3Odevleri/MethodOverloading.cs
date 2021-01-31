using System;
using System.Collections.Generic;
using System.Text;

namespace Gun3Odevleri
{
    class MethodOverloading
    {
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Multiply(int num1, int num3, int num2)
        {
            return num2 * num1 * num3;
        }
        /*Yukarıdaki 2 metodun isimleri, döndürdükleri tipler aynıdır
         * fakat imzaları farklıdır. İmzaları veri tipleri, isimleri, 
         * parametrelerinin tipleri ve sayları ile belirlenir. Buna 
         * metot overloading yani aşırı yüklenmesi denir.
         */
    } 
}
