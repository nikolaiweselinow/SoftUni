class SumOfNNumbers
{
    static void Main(string[] args)
    {
        System.Console.Title = "Problem 9.	Sum of n Numbers";

        decimal n = decimal.Parse(System.Console.ReadLine());
        decimal sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += decimal.Parse(System.Console.ReadLine());
        }

        System.Console.WriteLine(sum);
    }
}

