﻿using System;

namespace Task10
{
    //10. Напишете програма, която приема за вход четирицифрено число във формат abcd  (например числото 2011) и след това извършва следните действия върху него: 
    // - Пресмята сбора от цифрите на числото (за нашия пример 2+0+1+1 = 4).
    // - Разпечатва на конзолата цифрите в обратен ред: dcba (за нашия пример резултатът е 1102).
    // - Поставя последната цифра на първо място: dabc(за нашия пример резултатът е 1201). 
    // - Разменя мястото на втората и третата цифра: acbd (за нашия пример резултатът е 2101). 

    class Program
    {
        static void Main(string[] args)
        {
            int num = 6789;
            int d = num % 10;
            int c = (num / 10) % 10;
            int b = (num / 100) % 10;
            int a = (num / 1000) % 10;
            Console.WriteLine("сборът на цифрите на числото е : "+(a+b+c+d));
            Console.WriteLine("обратният ред на цифрите в числото е : " + d + c + b +a);
            Console.WriteLine("с последната цифра отпред, числото е : " + d + a + b + c);
            Console.WriteLine("с разменени 2ра и 3та цифра, числото е : "  + a + c+ b + d);

        }
    }
}
