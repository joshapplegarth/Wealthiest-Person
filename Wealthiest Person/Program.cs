using System;

namespace Wealthiest_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] accounts = new int[3][]
            {
                               new int[3] {100, 200, 300 },
                               new int[1] {500},
                               new int[4] {400, 600, 500, 0},
             };
            Console.WriteLine(MaximumWealth(accounts)); 
        }
        public static int MaximumWealth(int[][] bankRoll)
        {
            int richKid = 0;


            for (int i = 0; i < bankRoll.Length; i++)
            {
                int sum = 0;


                for (int j = 0; j < bankRoll[i].Length; j++)
                {
                    sum += bankRoll[i][j];
                }


                if (sum > richKid)
                {
                    richKid = sum;
                }
            }
            return richKid;
        }
    }
}
