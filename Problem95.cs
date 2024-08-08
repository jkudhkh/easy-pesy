using System;
using System.Collections;
namespace Application
{
    public class Problem95
    {
        public static void solution()
        {
            Student obj = new Student("Nisha", 17);
            Student obj1 = new Student("Namrata", 17);
            ArrayList students1 = new ArrayList { obj, obj1 };
            Class obj2 = new Class("class3", students1);
            ArrayList claasses3 = new ArrayList { obj2 };
            School obj22 = new School("Devaki Secondary Technical School", claasses3);
            obj22.DisplaySchoolInfo();
        }
        public class Student
        {
            public string Name;
            public int Age;
            public Student(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public void DisplayStudentInfo()
            {
                Console.WriteLine($"Student Name : {Name}, Age : {Age}");
            }
        }
        public class Class
        {
            public string Classname;
            public ArrayList Students;
            public Class(string classname, ArrayList students)
            {
                Classname = classname;
                Students = students;
            }
            public void displayInfo()
            {
                Console.WriteLine($"Classname : {Classname}");
                Console.WriteLine("Students:");
                foreach (Student student in Students)
                {
                    student.DisplayStudentInfo();
                }
            }
        }
        public class School
        {
            public string Schoolname;
            public ArrayList Classes;
            public School(string schoolname, ArrayList classes)
            {
                Schoolname = schoolname;
                Classes = classes;
            }
            public void DisplaySchoolInfo()
            {
                Console.WriteLine($"Schoolname : {Schoolname}");
                Console.WriteLine("Classes:");
                foreach (Class claass in Classes)
                {
                    claass.displayInfo();
                }
            }
        }
    }
}