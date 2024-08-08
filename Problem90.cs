using System;
namespace Application
{
    public class Doctor
    {
        public string Name { get; set; }
        public string Field { get; set; }

        public Doctor(string name, string field)
        {
            Name = name;
            Field = field;
        }

        public void DisplayDoctor()
        {
            Console.WriteLine($"Doctor: {Name}, Field: {Field}");
        }
    }

    public class Surgeon : Doctor
    {
        public string Specialty { get; set; }

        public Surgeon(string name, string field, string specialty) : base(name, field)
        {
            Specialty = specialty;
        }

        public void DisplaySurgeon()
        {
            Console.WriteLine($"Surgeon: {Name}, Field: {Field}, Specialty: {Specialty}");
        }
    }

    public class Nurse : Surgeon
    {
        public string Department { get; set; }

        public Nurse(string name, string field, string specialty, string department) : base(name, field, specialty)
        {
            Department = department;
        }

        public void DisplayNurse()
        {
            Console.WriteLine($"Nurse: {Name}, Field: {Field}, Specialty: {Specialty}, Department: {Department}");
        }
    }

    public class Hospital<T, P> where T : Doctor where P : Nurse
    {
        public string Name { get; set; }
        public T[] Doctors { get; set; }
        public P[] Nurses { get; set; }

        public Hospital(string name, T[] doctors, P[] nurses)
        {
            Name = name;
            Doctors = doctors;
            Nurses = nurses;
        }

        public void DisplayHospital()
        {
            Console.WriteLine($"Hospital: {Name}");
            Console.WriteLine("Doctors:");
            foreach (var doctor in Doctors)
            {
                doctor.DisplayDoctor();
            }
            Console.WriteLine("Nurses:");
            foreach (var nurse in Nurses)
            {
                nurse.DisplayNurse();
            }
        }
    }

    class Problem90
    {
        public static void solution()
        {
            Surgeon surgeon1 = new Surgeon("Dr. Sanduk Ruit", "Surgery", "Ophthalmologist");
            Surgeon surgeon2 = new Surgeon("Dr. Babu Ram Arya", "Surgery", "Neurology");

            Nurse nurse1 = new Nurse("Nurse Dilmaya Thapa", "Nursing", "Surgery", "Emergency");
            Nurse nurse2 = new Nurse("Sunita Tamang", "Nursing", "Pediatrics", "Child Care");

            Surgeon[] surgeons = new Surgeon[] { surgeon1, surgeon2 };
            Nurse[] nurses = new Nurse[] { nurse1, nurse2 };

            Hospital<Surgeon, Nurse> hospital = new Hospital<Surgeon, Nurse>("City Hospital", surgeons, nurses);

            hospital.DisplayHospital();
        }
    }
}
