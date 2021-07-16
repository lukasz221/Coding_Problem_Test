using System;
using System.Diagnostics;

namespace Coding_Problem_Test
{
    class Program
    {
        public static int arraySize = 400;
        public static int[] array = new int[arraySize];
        public static int k = 17;
        public static int countKNumbers = 0;

        public static int Min = 0;
        public static int Max = 10;

        static void Main(string[] args)
        {
            RandomArray();
            var watch = Stopwatch.StartNew();
            Check();
            watch.Stop();
            Console.WriteLine("Execution for " + arraySize + " random items: " + countKNumbers + " elapsed time: "+ watch.Elapsed + " seconds.");
            Console.ReadKey();
        }

        public static void Check()
        {
            int result;
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    result = array[i] + array[j];
                    if (result == k)
                    {
                        countKNumbers += 1;
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
