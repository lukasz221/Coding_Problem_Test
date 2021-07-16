using System;

namespace Coding_Problem_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Check().ToString());
            Console.ReadKey();
        }

        public static int[] tab = new int[4] { 10, 15, 3, 7 };
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
    }
}
