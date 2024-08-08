using System;
namespace ConsoleAppss
{
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
            Console.WriteLine($"Student Name: {Name}, Age: {Age}");
        }
    }
    public class Class
    {
        public string Cname;
        public Student[] Students;
        public Class(string cname, Student[] students)
        {
            Cname = cname;
            Students = students;
        }
        public void displayInfo()
        {
            Console.WriteLine($"Cname: {Cname}");
            Console.WriteLine("Studeents:");
            foreach (var student in Students)
            {
                student.DisplayStudentInfo();
            }
        }
    }
    public class Employee
    {
        public string Name;
        public int Id;
        public int Age;
        public Employee(string name, int id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }
        public void Einfo()
        {
            Console.WriteLine($"Name:{Name}, Id:{Id}Age:{Age}");
        }
    }
    public class Teacher : Employee
    {
        public int Teacherid;
        public Teacher(string name, int id, int age, int teacherid) : base(name, id, age)
        {
            Teacherid = teacherid;
        }
        public void Teacherinfo()
        {
            Console.WriteLine($" Name:{Name}, Id:{Id}, Age:{Age},Teacherid:{Teacherid}");
        }
    }
    public class Admin : Employee
    {
        public int Adminid;
        public Admin(string name, int id, int age, int adminid) : base(name, id, age)
        {
            Adminid = adminid;
        }
        public void Admininfo()
        {
            Console.WriteLine($" Name:{Name}, Id:{Id}, Age:{Age},Admminid:{Adminid},");
        }
    }
    public class School
    {
        public string Name;
        public Class[] Classes;
        public Employee[] Employees;
        public School(string name, Class[] classes, Employee[] employees)
        {
            Name = name;
            Classes = classes;
            Employees = employees;
        }
        public void Addemployee(Employee employee)
        {
            var updatedEmployee = new Employee[Employees.Length + 1];
            Employees.CopyTo(updatedEmployee, 0);
            updatedEmployee[Employees.Length] = employee;
            Employees = updatedEmployee;
        }
        public void DisplaySchoolInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine("Claasses");
            foreach (var classes in Classes)
            {
                classes.displayInfo();
            }
        }
    }
    public class Problem82
    {
        public static void solution()
        {
            Student obj = new Student("pabitra", 17);
            Student obj1 = new Student("Nisha", 16);
            Employee objz = new Employee("sarita", 23, 21);
            Teacher objn = new Teacher("Sarika", 6, 20, 11);
            Admin objb = new Admin("Puja", 7, 24, 9);
            Student[] studeents1 = new Student[] { obj, obj1 };
            Class obj2 = new Class("class3", studeents1);
            Class[] claasses3 = new Class[] { obj2 };
            Employee[] employees90 = new Employee[] { objn, objb };
            School obj25 = new School("Shree Devaki Secondary", claasses3, employees90);
            obj25.DisplaySchoolInfo();
            obj25.Addemployee(objn);
            objn.Teacherinfo();
            objb.Admininfo();
        }
    }
}
