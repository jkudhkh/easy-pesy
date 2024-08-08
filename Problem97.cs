using System;
using System.Collections.Generic;
namespace Application
{
    public class Problem97
    {
        public static void solution()
        {
            Student obj = new Student("Suman", "Kc", 26);
            Student objj = new Student("Sorgam", "Thapa", 18);
            List<Student> students = new List<Student> { obj, objj };
            Class<Student> myClass = new Class<Student>("Ten", students);
            List<Class<Student>> classes = new List<Class<Student>> { myClass };
            School school = new School("Shree Devaki", classes);
            school.SchoolInfo();
        }
        public class Student
        {
            public string Firstname;
            public string Lastname;
            public int Rollno;
            public Student(string firstname, string lastname, int rollno)
            {
                Firstname = firstname;
                Lastname = lastname;
                Rollno = rollno;
            }
            public void StudentInfo()
            {
                Console.WriteLine($"Firstname: {Firstname}, Lastname: {Lastname}, Rollno: {Rollno}");
            }
        }
        public class Class<T>
        {
            public string Grade;
            public List<T> Students;
            public Class(string grade, List<T> students)
            {
                Grade = grade;
                Students = students;
            }
            public void ClassInfo()
            {
                Console.WriteLine($"Grade: {Grade}");
                Console.WriteLine("Students:");
                foreach (var student in Students)
                {
                    if (student is Student studentObj)
                    {
                        studentObj.StudentInfo();
                    }
                }
            }
        }
        public class School
        {
            public string Schoolname;
            public List<Class<Student>> Classes;
            public School(string schoolname, List<Class<Student>> classes)
            {
                Schoolname = schoolname;
                Classes = classes;
            }
            public void SchoolInfo()
            {
                Console.WriteLine($"Schoolname: {Schoolname}");
                Console.WriteLine("Classes:");
                foreach (var schoolClass in Classes)
                {
                    schoolClass.ClassInfo();
                }
            }
        }
    }
}