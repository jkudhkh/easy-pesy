using System;
namespace Application
{
    public class Problem79
    {
        public class School
        {
            public string SchoolName;
            public School(string schoolName)
            {
                SchoolName = schoolName;
            }
            public void DisplaySchoolInfo()
            {
                Console.WriteLine($"School Name: {SchoolName}");
            }
        }
        public class Class : School
        {
            public string ClassName;
            public Class(string schoolName, string className) : base(schoolName)
            {
                ClassName = className;
            }
            public void DisplayClassInfo()
            {
                Console.WriteLine($"Class Name: {ClassName}");
            }
        }
        public class Employee : School
        {
            public string EmployeeName;
            public Employee(string schoolName, string employeeName) : base(schoolName)
            {
                EmployeeName = employeeName;
            }
            public void DisplayEmployeeInfo()
            {
                Console.WriteLine($"Employee Name: {EmployeeName}");
            }
        }
        public class Student : Class
        {
            public string StudentName;
            public Student(string schoolName, string className, string studentName)
                : base(schoolName, className)
            {
                StudentName = studentName;
            }
            public void DisplayStudentInfo()
            {
                Console.WriteLine($"Student Name: {StudentName}");
            }
        }
        public class Teacher : Employee
        {
            public string Subject;
            public Teacher(string schoolName, string employeeName, string subject)
                : base(schoolName, employeeName)
            {
                Subject = subject;
            }
            public void DisplayTeacherInfo()
            {
                Console.WriteLine($"Teacher Subject: {Subject}");
            }
        }
        public class Admin : Employee
        {
            public string AdminRole;
            public Admin(string schoolName, string employeeName, string adminRole)
                : base(schoolName, employeeName)
            {
                AdminRole = adminRole;
            }
            public void DisplayAdminInfo()
            {
                Console.WriteLine($"Admin Role: {AdminRole}");
            }
        }

        public static void solution()
        {
            School school = new School("Devaki Secondary");
            Class myClass = new Class("Class 12A", "Class 12A");
            Student student = new Student("Devaki Secondary", "Class 12A", "Shrushant Lama");
            Teacher teacher = new Teacher("Devaki Secondary", "RPS", "UPS");
            // Display information
            school.DisplaySchoolInfo();
            myClass.DisplayClassInfo();
            student.DisplayStudentInfo();
            teacher.DisplayEmployeeInfo();
            teacher.DisplayTeacherInfo();

        }
    }
}