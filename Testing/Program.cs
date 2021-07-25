using System;
using System.Linq;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            const int num = 5;
            var arr = new int[num] {
                //2, 3, 4, 5, 6 
                2, 4, 6, 8, 10
            };

            var result = generalizedGCD(num, arr);

            Console.WriteLine(result.ToString()); // 1
        }

        public static int generalizedGCD(int num, int[] arr)
        {
            var minDiv = 1;

            for (var i = minDiv; i < int.MaxValue; i = i + minDiv)
            {
                foreach (var i1 in arr)
                {
                    
                }
                if (arr.All(a=> a%i == 0))
                {
                    return i;
                }
            }

            return 1;
        }

        public static void TestCellCompete()
        {
            var input = new int[10]
            {
                0, 
                //1, 0, 0, 0 ,0, 1, 0, 0,
                1, 1, 1, 0, 1, 1, 1, 1,
                0
            };

            var result = cellCompete(input, 2);

            Console.WriteLine(result.ToString()); // 0 1 0 0 1 0 1 0 // 0 0 0 0 0 1 1 0
        }

        public static int[] cellCompete(int[] states, int days)
        {
            var result = new int[8];

            for (int i = 0; i < days; i++)
            {
                for (int j = 1; j < (states.Length - 1); j++)
                {
                    if (states[j -1] == states[j + 1])
                    {
                        result[j - 1] = 0;
                    }
                    else
                    {
                        result[j - 1] = 1;
                    }
                }

                for (int z = 1; z < states.Length - 1; z++)
                {
                    states[z] = result[z - 1];
                }
            }

            return result;
        }
    }
}
