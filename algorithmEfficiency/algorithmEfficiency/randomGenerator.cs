using System;
using System.Linq;

namespace AlgorithmEfficiency
{
    public class RandomGenerator
    {
        private static Random random = new Random();

        public static int[] GenerateRandom(int size, int minVal, int maxVal)
        {
            int[] a = new int[size];

            for (int i = 0; i < size; i++)
            {
                a[i] = random.Next(minVal, maxVal + 1);
            }

            return a;
        }

        public static int[] GenerateSorted(int size, int minVal, int maxVal)
        {
            int[] a = new int[size];

            for (int i = 0; i < size; i++)
            {
                a[i] = random.Next(minVal, maxVal + 1);
            }

            Array.Sort(a);
            return a;
        }

        public static int[] GenerateReversed(int size, int minVal, int maxVal)
        {
            int[] a = new int[size];

            for (int i = 0; i < size; i++)
            {
                a[i] = random.Next(minVal, maxVal + 1);
            }

            Array.Reverse(a);
            return a;
        }


    }
}