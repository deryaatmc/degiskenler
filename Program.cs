// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace degiskenler
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int deger = 2;             
            string degisken = null; 
            string Degisken = null;  // C# büyük-küçük harf duyarlıdır.
            byte b = 5;               // 1 byte bellek alanı
            sbyte c = 5;              // 1 byte
            short s = 5;              // 2 byte
            ushort us = 5;            // 2 byte
            Int32 i = 5;             // 4 byte
            Int64 l = 5;             // 8 byte

            uint ui = 5;             // 4 byte
            long lo = 5;             // 8 byte
            ulong ul = 5;            // 8 byte

            float f = 5;             // 4 byte
            double d = 5;            // 8 byte
            decimal de = 5;          // 16 byte

            char ch = '2';           // 2 byte
            string str = "Burak";    // Sınırsız

            bool b1 = true;           // 1 byte
            bool b2 = false;          // 1 byte

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            Console.WriteLine(deger);
        }
    }
}