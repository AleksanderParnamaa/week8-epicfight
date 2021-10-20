using System;

namespace SumOfArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 222, 3442, 42535, 342234, 3553535, 42424, 53535, 3333 };
            Console.WriteLine($"Sum of all elements: {SumOfArrayElements(numbers)}");
        }
        private static int SumOfElements(int[] someArray)
        {
            int sum = 0;
            for(int i=0;i < someArray.Length, i++)
            { sum = sum + someArray[i]};
            return sum;
        }
    }
}
