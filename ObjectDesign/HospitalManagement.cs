//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ObjectDesign
//{
//    using System;
//    using System.Collections.Generic;

//    class Patient
//    {
//        public string Name { get; set; }
//        public List<Doctor> DoctorsConsulted { get; set; }

//        public Patient(string name)
//        {
//            Name = name;
//            DoctorsConsulted = new List<Doctor>();
//        }

//        // Method to consult a doctor
//        public void Consult(Doctor doctor)
//        {
//            if (!DoctorsConsulted.Contains(doctor))
//            {
//                DoctorsConsulted.Add(doctor);
//                doctor.Consult(this); // Add this patient to the doctor's list of patients
//            }
//            else
//            {
//                Console.WriteLine($"{Name} has already consulted Dr. {doctor.Name}.");
//            }
//        }

//        // View patient's consultation history
//        public void ViewConsultations()
//        {
//            Console.WriteLine($"{Name}'s consultations:");
//            foreach (var doctor in DoctorsConsulted)
//            {
//                Console.WriteLine($"- Dr. {doctor.Name}");
//            }
//        }
//    }

//    class Doctor
//    {
//        public string Name { get; set; }
//        public List<Patient> PatientsConsulted { get; set; }

//        public Doctor(string name)
//        {
//            Name = name;
//            PatientsConsulted = new List<Patient>();
//        }

//        // Method to consult a patient and show communication
//        public void Consult(Patient patient)
//        {
//            if (!PatientsConsulted.Contains(patient))
//            {
//                PatientsConsulted.Add(patient);
//            }

//            Console.WriteLine($"Consulting {patient.Name}:");
//            Console.WriteLine($"Dr. {Name}: Hello {patient.Name}, how can I assist you today?");
//            Console.WriteLine($"{patient.Name}: I am not feeling well, Dr. {Name}. Could you help me?");
//            Console.WriteLine($"Dr. {Name}: Let me check your symptoms, and we'll find a solution.");
//        }

//        // View doctor's consultation history
//        public void ViewConsultations()
//        {
//            Console.WriteLine($"Dr. {Name}'s consultations:");
//            foreach (var patient in PatientsConsulted)
//            {
//                Console.WriteLine($"- {patient.Name}");
//            }
//        }
//    }

//    class Hospital
//    {
//        public string Name { get; set; }
//        public List<Doctor> Doctors { get; set; }
//        public List<Patient> Patients { get; set; }

//        public Hospital(string name)
//        {
//            Name = name;
//            Doctors = new List<Doctor>();
//            Patients = new List<Patient>();
//        }

//        // Method to add a doctor to the hospital
//        public void AddDoctor(Doctor doctor)
//        {
//            Doctors.Add(doctor);
//        }

//        // Method to add a patient to the hospital
//        public void AddPatient(Patient patient)
//        {
//            Patients.Add(patient);
//        }

//        // View the hospital details
//        public void ViewHospital()
//        {
//            Console.WriteLine($"Hospital: {Name}");
//            Console.WriteLine("Doctors:");
//            foreach (var doctor in Doctors)
//            {
//                Console.WriteLine($"- Dr. {doctor.Name}");
//            }
//            Console.WriteLine("Patients:");
//            foreach (var patient in Patients)
//            {
//                Console.WriteLine($"- {patient.Name}");
//            }
//        }
//    }

//    class HospitalManagement
//    {
//        static void Main()
//        {
//            // Create a hospital
//            Console.Write("Enter the name of the hospital: ");
//            string hospitalName = Console.ReadLine();
//            Hospital hospital = new Hospital(hospitalName);

//            // Add doctors to the hospital
//            Console.Write("Enter the number of doctors: ");
//            int numDoctors = int.Parse(Console.ReadLine());
//            for (int i = 0; i < numDoctors; i++)
//            {
//                Console.Write($"Enter name of doctor {i + 1}: ");
//                string doctorName = Console.ReadLine();
//                Doctor doctor = new Doctor(doctorName);
//                hospital.AddDoctor(doctor);
//            }

//            // Add patients to the hospital
//            Console.Write("Enter the number of patients: ");
//            int numPatients = int.Parse(Console.ReadLine());
//            for (int i = 0; i < numPatients; i++)
//            {
//                Console.Write($"Enter name of patient {i + 1}: ");
//                string patientName = Console.ReadLine();
//                Patient patient = new Patient(patientName);
//                hospital.AddPatient(patient);
//            }

//            // Simulate consultations
//            foreach (var patient in hospital.Patients)
//            {
//                Console.WriteLine($"\n{patient.Name}, choose a doctor to consult:");
//                for (int i = 0; i < hospital.Doctors.Count; i++)
//                {
//                    Console.WriteLine($"{i + 1}. Dr. {hospital.Doctors[i].Name}");
//                }
//                int doctorChoice = int.Parse(Console.ReadLine()) - 1;
//                if (doctorChoice >= 0 && doctorChoice < hospital.Doctors.Count)
//                {
//                    patient.Consult(hospital.Doctors[doctorChoice]);
//                }
//                else
//                {
//                    Console.WriteLine("Invalid doctor choice.");
//                }
//            }

//            // View consultations for each patient
//            foreach (var patient in hospital.Patients)
//            {
//                patient.ViewConsultations();
//            }

//            // View consultations for each doctor
//            foreach (var doctor in hospital.Doctors)
//            {
//                doctor.ViewConsultations();
//            }
//        }
//    }

//}
