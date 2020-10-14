using System;

namespace lekcii
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;
            //Console.WriteLine(a+b);
            //Console.WriteLine(a-b);
            //Console.WriteLine(a/b);
            //Console.WriteLine(a*b);
            //Console.WriteLine(a++);
            //Console.WriteLine(a);
            //Console.WriteLine(++a);
            //Console.WriteLine(a--);
            //Console.WriteLine(a);
            //Console.WriteLine(--a);
            //Console.WriteLine(a % b);

            //Console.WriteLine(a>b);
            //Console.WriteLine(a<b);
            //Console.WriteLine(a==b);
            //Console.WriteLine(a!=b);

            //a += 5; // a = a + 5
            //a -= 5;
            //a *= 4;
            //a /= 2;
            //a %= 2;

            //pobitovi operatori
            byte myByte1 = 1; // 0 0 0 0 0 0 0 1
            Console.WriteLine(myByte1 << 1); // 0 0 0 0 0 0 1 0
            Console.WriteLine(2 >> 1); // 0 0 0 0 0 0 0 1
            Console.WriteLine(1 | 2); // 0 0 0 0 0 0 1 1
            Console.WriteLine(1 & 2); // 0 0 0 0 0 0 0 0
            Console.WriteLine(1 ^ 3); // 0 0 0 0 0 0 1 0

            //operatori za preobrazuvane
            Console.WriteLine((double)a/b);
            Console.WriteLine((a>b)? "a is greater than b" : "b is greater than a");

            int? a1 = 5;
            int b1 = 6;
            a1 = null;
            int? z = a1 ?? b1;
        }
    }
}
