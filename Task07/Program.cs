using System;

namespace Task07
{
    class Program
    {
        //7. Силата на гравитационното поле на Луната е приблизително 17% от това на Земята. Напишете програма, която да изчислява тежестта на човек на Луната по дадената тежест на Земята. 
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете теглото си в КГ");
            int weight = int.Parse(Console.ReadLine());
            double moonWeight = weight * 0.17;
            Console.WriteLine("лунното ви тегло е: " + moonWeight + " kg");

            //Console.Write("Enter number: ");
            //int number = Convert.ToInt32(Console.ReadLine()); 
        }
    }
}
