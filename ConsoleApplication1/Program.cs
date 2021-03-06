﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int  i in Power(2,8))
            {
                Console.Write("{0} ", i);
            }
            Console.ReadKey();
        }
        public static IEnumerable<int> Power(int number,int exponent)
        {
            int result = 1;
            for(int i=0; i<exponent; i++)
            {
                result = result * number;
                yield return result;
            }
        }
    }
}
