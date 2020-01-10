﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num = 38293367;
            Console.Write(printMaxNum(num));
            Console.ReadKey();
        }
        static int printMaxNum(int num)
        {
         
            int[] count = new int[10];

          
            String str = num.ToString();

         
            for (int i = 0; i < str.Length; i++)
                count[str[i] - '0']++;

          
            int result = 0, multiplier = 1;

           
            for (int i = 0; i <= 9; i++)
            {
                while (count[i] > 0)
                {
                    result = result + (i * multiplier);
                    count[i]--;
                    multiplier = multiplier * 10;
                }
            }

           
            return result;
        }
    }
}