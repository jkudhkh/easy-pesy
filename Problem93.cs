using System;
namespace Application
{
    public class Problem93
    {
        public static void solution()
        {
            Disease1 disease1 = new Disease1("Cancer");
            Disease1 diseaseA1 = new Disease1("Allergy");
            Disease1[] ff = new Disease1[] { disease1, diseaseA1 };
            Doctor doctor = new SurgeonDoctor("DR Susmita", "DR Sanduk");
            Hospital<Disease1, Doctor> obj = new Hospital<Disease1, Doctor>("Makwanpur", ff, doctor);
            Disease2 diseaseB = new Disease2("Chickenpox");
            Disease2 diseaseB1 = new Disease2("Birdflu");
            Disease2[] ufff = new Disease2[] { diseaseB, diseaseB1 };
            Doctor doctor1 = new NurseDoctor("DR Naru", "DR Maruwa");
            Hospital<Disease2, Doctor> obj1 = new Hospital<Disease2, Doctor>("Nurse center", ufff, doctor);
            obj.ShowHospital();
            obj1.ShowHospital();
        }
        public class Disease1
        {
            public string DiseaseName;
            public Disease1(string diseasename)
            {
                DiseaseName = diseasename;
            }
            public void ShowDiseaseA()
            {
                Console.WriteLine($"DiseaseName:{DiseaseName}");
            }
        }
        public class Disease2
        {
            public string DiseaseName;
            public Disease2(string diseasename)
            {
                DiseaseName = diseasename;
            }
            public void ShowDiseaseB()
            {
                Console.WriteLine($"DiseaseName:{DiseaseName}");
            }
        }
        class Patient<T>
        {
            public string PatientName;
            public T[] Diseases;
            public Patient(string patientname, T[] diseases)
            {
                PatientName = patientname;
                Diseases = diseases;
            }
            public void ShowPatient()
            {
                Console.WriteLine($"PatientName:{PatientName}");
                Console.WriteLine("Diseases:");
                foreach (var diseases in Diseases)
                {
                    if (diseases is Disease1 diseasea)
                    {
                        diseasea.ShowDiseaseA();
                    }
                    else if (diseases is Disease2 diseaseB)
                    {
                        diseaseB.ShowDiseaseB();
                    }
                }
            }
        }
        class Doctor
        {
            public string DoctorName;
            public Doctor(string doctorname)
            {
                DoctorName = doctorname;
            }
            public void ShowDoctor()
            {
                Console.WriteLine($"DoctorName:{DoctorName}");
            }
        }
        class SurgeonDoctor : Doctor
        {
            public string SurgeonDoctorName;
            public SurgeonDoctor(string doctorname, string surgeondoctorname) : base(doctorname)
            {
                SurgeonDoctorName = surgeondoctorname;
            }
            public void ShowHD()
            {
                Console.WriteLine($"SurgeonDoctorName:{SurgeonDoctorName}");
            }
        }
        class NurseDoctor : Doctor
        {
            public string NurseDoctorName;
            public NurseDoctor(string doctorname, string nursedoctorname) : base(doctorname)
            {
                NurseDoctorName = nursedoctorname;
            }
            public void ShowAD()
            {
                Console.WriteLine($"NurseDoctorName:{NurseDoctorName}");
            }
        }
        class Hospital<T, P>
        {
            public string HospitalName;
            public T[] Patients;
            public P Doctors;
            public Hospital(string hospitalname, T[] patients, P doctors)
            {
                HospitalName = hospitalname;
                Patients = patients;
                Doctors = doctors;
            }
            public void ShowHospital()
            {
                Console.WriteLine($"HospitalRate:{HospitalName}");
                foreach (var patient in Patients)
                {
                    if (patient is Disease1 diseasea)
                    {
                        diseasea.ShowDiseaseA();
                    }
                    else if (patient is Disease2 diseaseb)
                    {
                        diseaseb.ShowDiseaseB();
                    }
                }
                if (Doctors is SurgeonDoctor surgeon)
                {
                    surgeon.ShowHD();
                }
                else if (Doctors is NurseDoctor animal)
                {
                    animal.ShowAD();
                }
            }
        }
    }
}