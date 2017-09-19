using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = {0,1,2,4,113,55,3,66,557,124,2,1};

            int[] sizes = new int[3];
            int[] offsets = new int[3];

            foreach (var number in numbers)
            {
                int remainder = number%3;
                sizes[remainder]++;

                Console.Write(number+" ");
            }

            Console.WriteLine("");

            int[][] numbersByRemainder = new int[3][]{
                new int[sizes[0]],
                new int[sizes[1]],
                new int[sizes[2]]
            };

            foreach (var number in numbers)
            {
                int remainder = number%3;
                int index = offsets[remainder];
                numbersByRemainder[remainder][index] = number;
                offsets[remainder]++;
            }

            foreach (var item in numbersByRemainder)
            {
                foreach (var item1 in item)
                {
                    Console.Write(item1+" ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");

            Console.WriteLine("aaHello World!,{0},{1}",numbersByRemainder.Rank,numbersByRemainder.Length);
        }
    }
}
