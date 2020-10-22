using System;

namespace Task02
{
    class Program
    {
        //2. Напишете булев израз, който да проверява дали дадено цяло число се дели и на 5, и на 7 без остатък
        static void Main(string[] args)
        {
            int num = 35;
            bool check = num % 5 == 0 & num % 7 == 0; 
            Console.WriteLine(check);
            // може да се направи директна проверка с делене на 35 (7 по 5) дали дава остатък 0
        }
    }
}
