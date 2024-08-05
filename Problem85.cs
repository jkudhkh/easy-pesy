using System;
namespace Application
{
    public class Bidhayalaya
    {
        public String Name;
        public int Age;

        public Bidhayalaya(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    public class Classs<T>
    {
        public int Level;
        public T[] Bidhayalaya;
        public Classs(int level, T[] Bidhayalaya)
        {
            this.Level = level;
            this.Bidhayalaya = Bidhayalaya;
        }
    }

    class Problem85
    {
        public static void solution()
        {
            Bidhayalaya c1 = new Bidhayalaya("Namrata", 11);
            Bidhayalaya c2 = new Bidhayalaya("Nisha", 12);
            Bidhayalaya[] aa = new Bidhayalaya[] { c1, c2 };
            Classs<Bidhayalaya> bb = new Classs<Bidhayalaya>(1, aa);

            foreach (var Bidhayalaya in bb.Bidhayalaya)
            {
                Console.WriteLine($"Name: {Bidhayalaya.Name}, Age: {Bidhayalaya.Age}");
            }
        }
    }
}