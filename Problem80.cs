using System;

namespace Application
{
    public class Problem80
    {
        public class Schoool
        {
            public string SchooolName;

            // Constructor
            public Schoool(string schooolName)
            {
                SchooolName = schooolName;
            }

            // Method//
            public void DisplaySchoolInfo()
            {
                Console.WriteLine($"School Name: {SchooolName}");
            }
        }

        public class Classs
        {
            public string ClasssName;
            public string SchooolName;

            // Constructor
            public Classs(string schooolName, string classsName)
            {
                SchooolName = schooolName;
                ClasssName = classsName;
            }

            // Method
            public void DisplayClassInfo()
            {
                Console.WriteLine($"Class Name: {ClasssName} in School: {SchooolName}");
            }
        }

        public class Employeee
        {
            public string SchooolName;
            public string EmployeeeName;

            // Constructor
            public Employeee(string schooolName, string employeeeName)
            {
                SchooolName = schooolName;
                EmployeeeName = employeeeName;
            }

            // Method
            public void DisplayEmployeeInfo()
            {
                Console.WriteLine($"Employee Name: {EmployeeeName} at School: {SchooolName}");
            }
        }

        public class Student
        {
            public string SchooolName;
            public string ClassName;
            public string StudentName;

            // Constructor
            public Student(string schooolName, string className, string studentName)
            {
                SchooolName = schooolName;
                ClassName = className;
                StudentName = studentName;
            }

            // Method
            public void DisplayStudentInfo()
            {
                Console.WriteLine($"Student Name: {StudentName} in Class: {ClassName} at School: {SchooolName}");
            }
        }

        public class Teacher : Employeee
        {
            public string Subject;

            // Constructor
            public Teacher(string schooolName, string employeeeName, string subject)
                : base(schooolName, employeeeName)
            {
                Subject = subject;
            }

            // Method
            public void DisplayTeacherInfo()
            {
                Console.WriteLine($"Teacher Name: {EmployeeeName}, Subject: {Subject} at School: {SchooolName}");
            }
        }

        public class Admin : Employeee
        {
            public string AdminRole;

            // Constructor
            public Admin(string schooolName, string employeeeName, string adminRole)
                : base(schooolName, employeeeName)
            {
                AdminRole = adminRole;
            }

            // Method
            public void DisplayAdminInfo()
            {
                Console.WriteLine($"Admin Role: {AdminRole} at Schoool: {SchooolName}");
            }
        }

        public static void solution()
        {
            Schoool schoool = new Schoool("Devaki Secondary");
            Classs myClass = new Classs("Devaki Secondary", "Class 12A");

            // Array of students
            Student[] students = new Student[]
            {
                new Student("Devaki Secondary", "Class 12A", "Surshant Lopchan"),
                new Student("Devaki Secondary", "Class 11A", "Prashant Lopchan"),
                new Student("Devaki Secondary", "Class 10A", "Susan Lopchan")
            };

            // Array of teachers
            Teacher[] teachers = new Teacher[]
            {
                new Teacher("Devaki Secondary", "RPS", "Mathematics"),
                new Teacher("Devaki Secondary", "Ups", "Physics"),
                new Teacher("Devaki Secondary", "Tabrej", "Chemistry")
            };

            // Display information
            schoool.DisplaySchoolInfo();
            myClass.DisplayClassInfo();

            Console.WriteLine("Students:");
            foreach (var student in students)
            {
                student.DisplayStudentInfo();
            }

            Console.WriteLine("Teachers:");
            foreach (var teacher in teachers)
            {
                teacher.DisplayTeacherInfo();
            }
        }
    }
}
