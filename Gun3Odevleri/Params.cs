using System;
using System.Collections.Generic;
using System.Text;

namespace Gun3Odevleri
{
    class Params
    {
        public static int Add(params int[] numbers)
        {
            int result = 0;
            foreach (var item in numbers)
            {
                result += item;
            }
            return result;
        }
    }
}
