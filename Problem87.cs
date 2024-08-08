using System;

namespace Application
{
    // Generic Person class
    public class Person<T>
    {
        public T Identifier { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(T identifier, string name, int age)
        {
            Identifier = identifier;
            Name = name;
            Age = age;
        }

        // Method to display person details
        public void DisplayPerson()
        {
            Console.WriteLine($"Identifier: {Identifier}, Name: {Name}, Age: {Age}");
        }
    }

    class Problem87
    {
        public static void solution()
        {
            // Using the Person class with an integer as an identifier
            Person<int> person1 = new Person<int>(1, "Suman Tamag", 20);
            person1.DisplayPerson();

            // Using the Person class with a string as an identifier
            Person<string> person2 = new Person<string>("2", "Flowra Tamang", 25);
            person2.DisplayPerson();
        }
    }
}
