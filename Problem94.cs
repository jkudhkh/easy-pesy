using System;
using System.Collections;
namespace Application
{
    public class Problem94
    {
        public static void solution()
        {
            Student student = new Student("Flowra", "Lima", 3);
            Student student1 = new Student("Kylie", "Jenner", 1);
            ArrayList arrayList = new ArrayList { student, student1 };
            Class classes = new Class("twelve", arrayList);
            ArrayList arrayList1 = new ArrayList { classes };
            Student student2 = new Student("Kendel", "Jenner", 6);
            classes.AddStudent(student2);
            School school = new School("SDSS", arrayList1);
            school.Schoolinfo();
        }
        class Student
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
            public void Studentinfo()
            {
                Console.WriteLine($"Firstname = {Firstname}, Lastname = {Lastname}, Rollno:{Rollno}");
            }
        }
        class Class
        {
            public string Grade;
            public ArrayList Students;
            public Class(string grade, ArrayList students)
            {
                Grade = grade;
                Students = students;
            }
            public void AddStudent(Student Newstudent)
            {
                Students.Add(Newstudent);
            }
            public void Classinfo()
            {
                Console.WriteLine($"Grade:{Grade}");
                Console.WriteLine("Students:");
                foreach (Student student in Students)
                {
                    student.Studentinfo();
                }
            }
        }
        class School
        {
            public string Schoolname;
            public ArrayList Classes;
            public School(string schoolname, ArrayList classes)
            {
                Schoolname = schoolname;
                Classes = classes;
            }
            public void Schoolinfo()
            {
                Console.WriteLine($"Schoolname:{Schoolname}");
                Console.WriteLine("Classes:");
                foreach (Class classes in Classes)
                {
                    classes.Classinfo();
                }
            }
        }
    }
}
