using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sqltest
{
    internal class Program
    {



        public static void Main()
        {
            Random random = new Random();
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[a, b];
            for (int i = 0; i < a; i++)
            {

                for (int j = 0; j < b; j++)
                {
                    arr[i, j] = random.Next(0, 100);
                }
            }


            int[,] temp = new int[2, 2];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    int temp[,] = arr[i, j];
                    if (arr[i, j] < arr[i, j + 1])
                    {
                        int temp[,] = arr[i, j];
                        arr[i, j] = arr[i, j + 1];
                        arr[i, j + 1] = temp;
                    }
                }



            }
















            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write($" {arr[i, j]}\t ");
                }
                Console.WriteLine();
            }











            Console.ReadKey();


        }
    }
}
