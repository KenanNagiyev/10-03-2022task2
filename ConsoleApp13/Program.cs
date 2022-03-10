using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, -2, 7, -8 };
            Console.WriteLine(MusMen(nums));
        }
        static int MusMen(int[] nums)
        {
            int menfi = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    menfi = nums[i] * (-1);
                    Console.WriteLine(menfi);

                }
                else
                {
                    Console.WriteLine(nums[i]);
                }

            }
            return 0;
        }
    }
}
