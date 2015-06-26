using System;
using System.Collections.Generic;
using System.Linq;

//Трудно разбрах условието на задачата, първоначално бях направил два масива с по n - елемента, защото си мислих, че трябва да сравнявам сумата на елементите на двата масива, но после разбрах, че трябва да сравнявам сумата на четните и нечетните места на елемента в масива! Ползвал съм LINQ, неможаш да го измисля по друг начин, но със сигурност има и по- лесно решение!
//Успех!

class OddEvenSum
{
    static void Main()
    {
        // Console.Title = "Problem 18.	** – Odd / Even Sum";
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n * 2];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        var odds = numbers.Where((item, index) => index % 2 != 0);
        var evens = numbers.Where((item, index) => index % 2 == 0);

        if (odds.Sum() == evens.Sum())
        {
            Console.WriteLine("Yes, sum={0}", odds.Sum());
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(evens.Sum() - odds.Sum()));
        }
    }
}
