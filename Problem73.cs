using System;
namespace Application
{
    class School
    {
        //inlitailizes
        public string Name;
        public string Location;

        //constructor
        public School(string name, string location)
        {
            Name = name;
            Location = location;
        }

        //print
        public void PrintDetails()
        {
            Console.WriteLine($"School Name: {Name}, Location: {Location}");
        }
    }

    class Students
    {

        //inlitailizes
        public string Name;
        public int Age;
        public int Grade;

        //constructor
        public Students(string name, int age, int grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        //print
        public void PrintDetails()
        {
            Console.WriteLine($"Student Name: {Name}, Age: {Age}, Grade: {Grade}");
        }
    }

    class Programs
    {
        //create object
        public static void solution()
        {
            School obj = new School("Nisha Shrestha", "bagmati, Bhorleni");
            Students obj1 = new Students("Nisha  Shrestha", 18, 12);
            obj.PrintDetails();
            obj1.PrintDetails();
        }
    }
}


