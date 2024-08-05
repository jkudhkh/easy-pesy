using System;
namespace Application
{

    public class Student
    {
        public string Name;
        public int Age;
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
    public class Class<T>
    {
        public int level;
        public T[] student;
        public Class(int level, T[] student)
        {
            this.level = level;
            this.student = student;
        }
    }


    class Problem84
    {
        public static void solution()
        {
            Student s1 = new Student("Nisha", 12);
            Student s2 = new Student("Namrata", 11);
            Student[] ss = new Student[] { s1, s2 };
            Class<Student> c1 = new Class<Student>(1, ss);

            foreach (var student in c1.student)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
}


