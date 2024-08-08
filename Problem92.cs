using System;
namespace Application
{

    class Problem92
    {
        public static void solution()
        {
            var car = new List<string>() { "BMW", "Tesla", "Suzuki", "Tesla" };

            // remove the first occurence of "Tesla" from the list
            car.Remove("Tesla");

            // remove the first occurrence of "Suzuki" 
            car.Remove("Suzuki");

            // print the updated list after removing   
            for (int i = 0; i < car.Count; i++)
            {
                Console.WriteLine(car[i]);

            }
        }
    }
}