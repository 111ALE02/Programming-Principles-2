﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n;
            string[] s = new string[256];
            string[,] a = new string[10000, 10000];
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    a[i, j] = "[*]";
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
