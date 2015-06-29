using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Title = "Problem 10.	Odd and Even Product";

        string[] numbers = Console.ReadLine().Split(' ');
        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentPos = int.Parse(numbers[i]);
            if (i % 2 == 0) 
                evenProduct = evenProduct * currentPos;
            
            else
                oddProduct = oddProduct * currentPos;
       }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes\nproduct = {0}", evenProduct);            
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product  = {0}", oddProduct);
            Console.WriteLine("even_product = {0}", evenProduct);
        }
       
    }
}

