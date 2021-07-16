using System;

namespace Coding_Problem_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            Console.WriteLine(Check().ToString());
            Console.ReadKey();
        }

        public static int[] tab = new int[400];
        public static int k = 17;


        public static bool Check()
        {
            int result;
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 1; j < tab.Length; j++)
                {
                    result = tab[i] + tab[j]; 

                    if (result == k)
                    {
                        //return true;
                        Console.WriteLine(i + " " + j);
                    }

                }
            }
            return false;
        }

        public static void RandomArray()
        {
            int Min = 0;
            int Max = 10;

            Random randNum = new Random();
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = randNum.Next(Min, Max);
            }
        }
    }
}
