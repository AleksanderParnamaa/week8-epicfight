﻿using System;

namespace ReturnStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 25;
            int result = AddTwoNumbers(a, b);
            Console.WriteLine($"{a} + {b} = {result}");
        }
        private static int AddTwoNumbers(int x, int y)
        {
            return x + y;
            
            }
        }
    }

