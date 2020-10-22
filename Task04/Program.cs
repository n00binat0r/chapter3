using System;

namespace Task04
{
    class Program
       // 4. Напишете израз, който да проверява дали третият бит на дадено число е 1 или 0.
    {
        static void Main(string[] args)
        {
            int num = 16;
            bool bit3 = ((num >> 3) & 1) == 1;
            Console.WriteLine(bit3);
        }
    }
}
