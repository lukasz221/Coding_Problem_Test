using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Coding_Problem_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindK().ToString());
        }

        public static bool FindK()
        {
            bool check = false;
            int k = 17;
            var list = new List<int> { 10, 15, 3, 7 };

            foreach (var item in list)
            {
                check = list.Contains(k - item);
                if (check)
                {
                    return check;
                }
            }
            return check;
        }
    }
}
