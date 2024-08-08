using System;
namespace Application
{

    class Problem89
    {
        public static void solution()
        {
            // create a list
            List<string> country = new List<string>() { "Russia" };

            //add "USA" to the country list
            country.Add("USA");

            // add "Japan" to the country list 
            country.Add("Japan");

            // iterate through the country list  
            for (int i = 0; i < country.Count; i++)
                Console.WriteLine(country[i]);
        }
    }
}