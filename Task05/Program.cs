using System;

namespace Task05
{
    //5. Напишете израз, който изчислява площта на трапец по дадени страни a и b и височина h. 
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 7;
            int h = 2;
            
            Console.WriteLine("s= {0}", ((a + b) * h / 2));
        }
    }
}
