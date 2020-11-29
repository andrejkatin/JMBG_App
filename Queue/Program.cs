using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3 };
            permutations(arr, 0, 2);
            Console.Read();
        }

        public static void permutations(int[] arr, int i, int length)
        {

            if (i == length)
            {

            }
            else
            {
                for (int j = 0; j <= length; j++)
                {

                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    Console.WriteLine(arr[0].ToString() + arr[1].ToString() + arr[2].ToString());


                    permutations(arr, i + 1, length);
                }


            }

        }
    }

}

