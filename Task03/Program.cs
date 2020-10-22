using System;
using System.Linq;

namespace Task03
{
    class Program
    {
        //3. Напишете израз, който да проверява дали третата цифра (от дясно наляво) на дадено цяло число е 7. 
        static void Main(string[] args)
        {
            int num = 1734;
            
            Console.WriteLine((num/100) % 10 == 7 ? true : false);

           
        }
    }
}
