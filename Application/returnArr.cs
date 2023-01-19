using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application
{
    public class returnArr
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("How many Rows do you want? ");
            int r = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("How many Columns do you want? ");
            int c = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[r, c];
            for (int i = 0; i < r; i++)
            {
                System.Console.WriteLine("Enter elements for Row {0}", i);
                for (int j = 0; j < c; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    System.Console.Write(arr[i, j] + " | ");
                }
                System.Console.WriteLine();
            }
        }
    }
}