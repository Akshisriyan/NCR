﻿/*
 * C# Program to Calculate the Value of nCr
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r,per,fact,fact1,fact2;
            Console.WriteLine("Enter the Value of 'n' and 'r' to " +
                              "find the Permutation :");
            n = Convert.ToInt32(Console.ReadLine());
            r = Convert.ToInt32(Console.ReadLine());
            fact = n;
            for (int i = n - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            fact2 = r;
            for (int i = r - 1; i >= 1; i--)
            {
                fact2 = fact2 * i;
            }
            int number;
            number = n - r;
            fact1 = number;
            for (int i = number - 1; i >= 1; i--)
            {
                fact1 = fact1 * i;
            }
            fact1 = fact2 * fact1;
            per = fact / fact1;
            Console.WriteLine("Combination : {0}",per);
            Console.ReadLine();
          }
    }
}