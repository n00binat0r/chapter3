using System;

namespace Task08
{
    class Program
    {
        //8. Напишете програма, която проверява дали дадена точка О {x, y} е вътре в окръжността К ({0,0}, R=5). Пояснение: точката {0,0} е център на окръжността, а радиусът ѝ е 5. 
        static void Main(string[] args)
        {
            Console.WriteLine("въведете кооридната Х на точката О");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("въведете кооридната Y на точката О");
            int y = Convert.ToInt32(Console.ReadLine());
            bool check = (x*x + y *y) <= 25 ? true : false;
            Console.WriteLine("Принадлежи ли точката О с координати: {0},{1} в кръга К с център 0,0 и радиус 5: {2}", x, y, check);
        }
    }
}
