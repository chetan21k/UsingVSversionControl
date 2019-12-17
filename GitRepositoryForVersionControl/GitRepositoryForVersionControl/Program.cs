using System;

namespace GitRepositoryForVersionControl
{
    class Program
    {
        public static void OddEven()
        {
            int[] odd = new int[250];
            int[] even = new int[250];
            for (int i = 1, j = 0, k = 0; i < 501; i++)
            {
                if (i % 2 == 0)
                {
                    even[j++] = i;
                }
                else
                {
                    odd[k++] = i;
                }

            }
            Console.WriteLine(" Even List:");
            Console.WriteLine(string.Join(",", even));

            Console.WriteLine(" Odd List:");
            Console.WriteLine(string.Join(",", odd));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program To Odd Even from 1 to 500");
            OddEven();


        }
    }
}
