using System;
namespace Application
{
    public class Problem98
    {
        public static void solution()
        {
            int[] arr = [1, 2, 3, 4, 5];
            int largest = arr[0];
            int length = arr.Length;
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > largest)
                    {
                        largest = arr[i];
                    }
                }
                Console.WriteLine(largest);
            }
        }
    }
}