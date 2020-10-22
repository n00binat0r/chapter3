using System;

namespace Task06
{
    class Program
    {
        //6. Напишете програма, която за подадени от потребителя дължина и височина на правоъгълник пресмята и отпечатва на конзолата неговите периметър и лице.
        static void Main(string[] args)
        {
            Console.WriteLine("въведете дължина");
            int lenght = int.Parse(Console.ReadLine());
            Console.WriteLine("въведете височина");
            int height = int.Parse(Console.ReadLine());
            int surface = lenght * height;
            int perimeter = 2 * (lenght + height);
            Console.WriteLine("Лицето на правоъгълникът е: " + surface + " Обиколката е: " + perimeter);
        }
    }
}
