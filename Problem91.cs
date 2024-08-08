using System;
namespace Application
{
    class Problem91
    {
        public static void solution()
        {
            // create a list
            List<string> albums = new List<string>() { "Red", "Midnight", "Reputation" };

            // iterate through the albums list  
            for (int i = 0; i < albums.Count; i++)
                Console.WriteLine(albums[i]);
        }
    }
}