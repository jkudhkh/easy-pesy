using System;
namespace Application
{
    class Problem78
    {
        public static void solution()
        {
            // Declare an array of integers with 5 elements
            int[] Students = new int[5];

            // Assign values to the array elements
            Students[0] = 10;
            Students[1] = 20;
            Students[2] = 30;
            Students[3] = 40;
            Students[4] = 50;

            // Print the array elements
            Console.WriteLine("The elements of the array are:");
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine(Students[i]);
            }

        }
    }
}