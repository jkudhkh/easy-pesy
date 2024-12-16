using System;
using System.Collections.Generic;
namespace ConsoleApp12
{
    public class Student
    {
        public string Studentname;
        public int Studentid;
        public int Age;
        public Student(string studentname, int studentid, int age)
        {
            Studentname = studentname;
            Studentid = studentid;
            Age = age;
        }
        public void StudentInfor()
        {
            Console.WriteLine($"Studentname: {Studentname}, Studentid: {Studentid}, Age: {Age}");
        }
    }
    public class Class
    {
        public string Classname;
        public List<Student> Students;
        public Class(string classname, List<Student> students)
        {
            Classname = classname;
            Students = students;
        }
        public void AddStudent(Student newStudent)
        {
            Students.Add(newStudent);
        }
        public void ClassInfor()
        {
            Console.WriteLine($"Classname: {Classname}");
            Console.WriteLine("Students:");
            foreach (Student student in Students)
            {
                student.StudentInfor();
            }
        }
    }
    public class School
    {
        public string Schoolname;
        public List<Class> Classes;
        public School(string schoolname, List<Class> classes)
        {
            Schoolname = schoolname;
            Classes = classes;
        }
        public void Sinfor()
        {
            Console.WriteLine($"Schoolname: {Schoolname}");
            Console.WriteLine("Cclass:");
            foreach (Class cclass in Classes)
            {
                cclass.ClassInfor();
            }
        }
    }
    public class Problem96
    {
        public static void solution()
        {
            Student obj1 = new Student("Pase", 9, 17);
            Student obj2 = new Student("Pari", 10, 16);
            List<Student> students44 = new List<Student> { obj1 };
            Class obj22 = new Class("Class6", students44);
            Student oobj = new Student("Nire", 34, 18);
            obj22.AddStudent(oobj);
            List<Class> classes66 = new List<Class> { obj22 };
            School obj8 = new School("Shree Devaki", classes66);
            obj8.Sinfor();
        }
    }
}