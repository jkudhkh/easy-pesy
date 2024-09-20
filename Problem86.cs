using System;
namespace Application
{
    class Studentss
    {
        public string Name;
        public int Age;

        public Studentss(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void DisplayStudent()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class StudentWithRollNo
    {
        public string Name;
        public int RollNumber;

        public StudentWithRollNo(string name, int rollNumber)
        {
            Name = name;
            RollNumber = rollNumber;
        }

        public void DisplayStudent()
        {
            Console.WriteLine($"Name: {Name}, Rollno: {RollNumber}");
        }
    }

    class Employees
    {
        public string Name;

        public Employees(string name)
        {
            Name = name;
        }

        public void DisplayEmployees()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }

    class Teacher : Employees
    {
        public string Subject;

        public Teacher(string name, string subject) : base(name)
        {
            Subject = subject;
        }

        public void DisplayTeacher()
        {
            Console.WriteLine($"Name: {Name}, Subject: {Subject}");
        }
    }

    class Admin : Employees
    {
        public Admin(string name) : base(name) { }
    }

    public class Class<T, P>
    {
        public int Level;
        public T[] Students;
        public P ClassTeacher;

        public Class(int level, P classTeacher, T[] students)
        {
            Level = level;
            Students = students;
            ClassTeacher = classTeacher;
        }

        public void DisplayClass()
        {
            Console.WriteLine($"Level: {Level}");
            if (ClassTeacher is Employees employees)
            {
                employees.DisplayEmployees();
                if (ClassTeacher is Teacher teacher)
                {
                    teacher.DisplayTeacher();
                }
            }
            Console.WriteLine("Students:");
            foreach (var student in Students)
            {
                if (student is Studentss s)
                {
                    s.DisplayStudent();
                }
                else if (student is StudentWithRollNo sr)
                {
                    sr.DisplayStudent();
                }
            }
        }
    }

    public class Problem86
    {
        public static void solution()
        {
            // Creating instances of Student and Teacher
            Student c1 = new Student("Surya", 1);
            Student c2 = new Student("Anusha", 2);
            Student[] students = new Student[] { c1, c2 };
            Teacher teacher = new Teacher("upendra Sir", "Physic");
            Class<Student, Employees> class1 = new Class<Student, Employees>(12, teacher, students);

            // Creating instances of StudentWithRollNo and Admin
            StudentWithRollNo sr1 = new StudentWithRollNo("Namrata", 12);
            StudentWithRollNo sr2 = new StudentWithRollNo("Nisha", 11);
            StudentWithRollNo[] studentsWithRollNo = new StudentWithRollNo[] { sr1, sr2 };
            Admin admin = new Admin("chndra B. Thapa");
            Class<StudentWithRollNo, Admin> class2 = new Class<StudentWithRollNo, Admin>(11, admin, studentsWithRollNo);

            // Displaying class details
            class1.DisplayClass();
            class2.DisplayClass();
        }
    }
}
