using System;

namespace Task09
{
    class Program
    {
        //Напишете програма, която проверява дали дадена точка О (x, y) е вътре в окръжността К ({0,0}, R=5) и едновременно с това извън правоъгълника [{-1, 1}, {5, 5}].
        //Пояснение: правоъгълникът е зададен чрез координатите на долния си ляв и горния си десен ъгъл. 
        static void Main(string[] args)
        {
            Console.WriteLine("въведете кооридната Х на точката О");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("въведете кооридната Y на точката О");
            int y = Convert.ToInt32(Console.ReadLine());

            bool checkCircle = (x * x + y * y) <= 25 ? true : false;
            bool checkRectangle = (x < -1 && x > 5 && y < 1 && y > 5) ? true : false;
            Console.WriteLine("Принадлежи ли точката О с координати: {0},{1} в кръга К с център 0,0 и радиус 5: {2}", x, y, checkCircle);
            Console.WriteLine("Принадлежи ли точката О с координати: {0},{1} в правоъгълник R с координати -1,1 и 5,5: {2}", x, y, checkRectangle);

            bool check = checkCircle == true && checkRectangle == false ? true : false;
            Console.WriteLine("точката в кръга ли е и извън правоъгълника ли е? : "+ check);
        }
    }
}
