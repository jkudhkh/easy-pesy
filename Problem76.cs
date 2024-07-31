using System;

namespace Application
{
    public class Problem76
    {
        public class Student
        {
            //Properties
            public string Name { get; set; }
            public int Grade { get; set; }
            //Constructor,initlizations
            public Student(string name, int grade)
            {
                Name = name;
                Grade = grade;
            }

            public void DisplayProperty()
            {
                Console.WriteLine($"Name: {Name}, Grade: {Grade}");
            }
        }

        public class Class
        {
            public string ClassName { get; set; }
            public Student[] Students { get; set; }

            public Class(string className, Student[] students)
            {
                ClassName = className;
                Students = students;
            }

            public void DisplayProperty()
            {
                Console.WriteLine($"Class Name: {ClassName}");
                Console.WriteLine("Students:");
                foreach (var student in Students)
                {
                    student.DisplayProperty();
                }
            }
        }

        public class School
        {
            public string SchoolName { get; set; }
            public Class[] Classes { get; set; }

            public School(string schoolName, Class[] classes)
            {
                SchoolName = schoolName;
                Classes = classes;
            }

            public void DisplayProperty()
            {
                Console.WriteLine("School:");
                Console.WriteLine($"School Name: {SchoolName}");
                Console.WriteLine("Classes:");
                foreach (var cls in Classes)
                {
                    cls.DisplayProperty();
                }
            }
        }

        public static void solution()
        {
            Student student = new Student("Nisha", 12);
            Student[] students = new Student[] { student };
            Class cls = new Class("Twelve", students);
            Class[] classes = new Class[] { cls };
            School school = new School("Devaki Ma.Vi", classes);
            school.DisplayProperty();
        }
    }
}
