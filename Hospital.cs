//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops2
//{
//    using System;

//    class Patient
//    {
//        // Static variable shared among all patients
//        public static string HospitalName = "City Care Hospital";

//        // Static variable to count total patients
//        private static int totalPatients = 0;

//        // Readonly variable for PatientID
//        public readonly int PatientID;

//        // Instance variables
//        public string Name { get; set; }
//        public int Age { get; set; }
//        public string Ailment { get; set; }

//        // Constructor using 'this' to initialize properties
//        public Patient(string name, int age, string ailment)
//        {
//            this.Name = name;
//            this.Age = age;
//            this.Ailment = ailment;
//            this.PatientID = ++totalPatients; // Auto-generate unique Patient ID
//        }

//        // Static method to get total patient count
//        public static void GetTotalPatients()
//        {
//            Console.WriteLine($"\nTotal patients admitted: {totalPatients}");
//        }

//        // Method to display patient details with 'is' operator check
//        public void DisplayDetails(object obj)
//        {
//            if (obj is Patient patient)
//            {
//                Console.WriteLine("\nPatient Details:");
//                Console.WriteLine($"Hospital Name : {HospitalName}");
//                Console.WriteLine($"Patient ID    : {patient.PatientID}");
//                Console.WriteLine($"Name          : {patient.Name}");
//                Console.WriteLine($"Age           : {patient.Age}");
//                Console.WriteLine($"Ailment       : {patient.Ailment}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid object. Cannot display patient details.");
//            }
//        }
//    }

//    // Example usage with user input
//    class Program
//    {
//        static void Main()
//        {
//            Console.Write("Enter the number of patients to admit: ");
//            int numPatients;
//            while (!int.TryParse(Console.ReadLine(), out numPatients) || numPatients <= 0)
//            {
//                Console.Write("Invalid input. Enter a valid number of patients: ");
//            }

//            Patient[] patients = new Patient[numPatients];

//            for (int i = 0; i < numPatients; i++)
//            {
//                Console.WriteLine($"\nEntering details for Patient {i + 1}:");

//                Console.Write("Enter patient name: ");
//                string name = Console.ReadLine();

//                Console.Write("Enter patient age: ");
//                int age;
//                while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
//                {
//                    Console.Write("Invalid age. Please enter a valid age: ");
//                }

//                Console.Write("Enter ailment: ");
//                string ailment = Console.ReadLine();

//                // Create Patient object
//                patients[i] = new Patient(name, age, ailment);
//            }

//            // Display details of all patients
//            foreach (var patient in patients)
//            {
//                patient.DisplayDetails(patient);
//            }

//            // Display total number of patients
//            Patient.GetTotalPatients();
//        }
//    }

//}
