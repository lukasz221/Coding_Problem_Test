using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Coding_Problem_Test
{
    class Program
    {
        public static int k = 17;

        public static int[] smallArray = new int[] { 11, 2, 8, 11, 9,};


        static void Main(string[] args)
        {
            var watch1 = Stopwatch.StartNew();

            var r1 = Method1(smallArray, k);
            watch1.Stop();
            Console.WriteLine("Execution for Method 1 array size: " + smallArray.Length + " items: " + r1.ToString() + " elapsed time: " + watch1.Elapsed + " seconds.");
            
            var watch2 = Stopwatch.StartNew();

            var r2 = Method2(smallArray, k);
            watch2.Stop();
            Console.WriteLine("Execution for Method 2 array size: " + smallArray.Length + " items: " + r2.ToString() + " elapsed time: " + watch2.Elapsed + " seconds.");

            Console.ReadKey();
        }

        public static bool Method1(int[] array, int k)
        {
            bool check = false;

            List<int> arrList = array.OfType<int>().ToList();

            foreach (var item in arrList)
            {
                check = arrList.Contains(k - item);

                if (check)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool Method2(int[] array, int k)
        {
            int result;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    result = array[i] + array[j];

                    if (result == k)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
