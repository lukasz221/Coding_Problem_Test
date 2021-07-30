using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Coding_Problem_Test
{
    class Program
    {
        public static int arraySize = 4000;
        public static int[] array = new int[arraySize];
        public static int k = 17;

        public static int countKNumbers1 = 0;
        public static int countKNumbers2 = 0;

        public static int Min = 0;
        public static int Max = 10;


        static void Main(string[] args)
        {
            RandomArray();

            var watch1 = Stopwatch.StartNew();

            Method1(array, k);
            watch1.Stop();
            Console.WriteLine("Execution for Method 1 array size: " + array.Length + " random items: " + countKNumbers1 + " elapsed time: " + watch1.Elapsed + " seconds.");
            
            var watch2 = Stopwatch.StartNew();
            Method2(array, k);
            watch2.Stop();
            Console.WriteLine("Execution for Method 2 array size: " + array.Length + " random items: " + countKNumbers2 + " elapsed time: " + watch2.Elapsed + " seconds.");

            Console.ReadKey();
        }

        public static void Method1(int[] array, int k)
        {
            bool check = false;

            List<int> arrList = array.OfType<int>().ToList();

            foreach (var item in arrList)
            {
                check = arrList.Contains(k - item);

                if (check)
                {
                    countKNumbers1 += 1;
                }
            }
        }

        public static void Method2(int[] array, int k)
        {
            int result;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    result = array[i] + array[j];

                    if (result == k)
                    {
                        countKNumbers2 += 1;
                    }
                }
            }
        }

        public static void RandomArray()
        {
            Random randNum = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(Min, Max);
            }
        }
    }
}
