using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StudentCables
{
    static void Main()
    {
        int numberOfCables = int.Parse(Console.ReadLine());

        int sumOfCables = 0;
        int countCables = 0;

        for (int i = 0; i < numberOfCables; i++)
        {
            int cableLength = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();

            switch (measure)
            {
                case "meters":
                    cableLength = cableLength * 100;
                    sumOfCables = sumOfCables + cableLength;
                    countCables++;
                    break;
                case "centimeters":
                    if (cableLength >= 20)
                    {
                        sumOfCables = sumOfCables + cableLength;
                        countCables++;                        
                    }                    
                    break;                    
                default:
                    break;
            }
        }

        sumOfCables -= 3 * (countCables - 1);

        Console.WriteLine(sumOfCables / 504);
        Console.WriteLine(sumOfCables % 504);
    }
}

