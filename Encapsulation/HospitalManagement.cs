using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    using System;
    using System.Collections.Generic;

    // Abstract class for Patient
    abstract class Patient
    {
        protected string patientId;
        protected string name;
        protected int age;

        public Patient(string patientId, string name, int age)
        {
            this.patientId = patientId;
            this.name = name;
            this.age = age;
        }

        public void GetPatientDetails()
        {
            Console.WriteLine($"Patient ID: {patientId}, Name: {name}, Age: {age}");
        }

        public abstract double CalculateBill();
    }

    // Interface for Medical Records
    interface IMedicalRecord
    {
        void AddRecord(string record);
        void ViewRecords();
    }

    // InPatient subclass
    class InPatient : Patient, IMedicalRecord
    {
        private double dailyCharge = 500;
        private int daysAdmitted;
        private List<string> medicalRecords = new List<string>();

        public InPatient(string patientId, string name, int age, int daysAdmitted)
            : base(patientId, name, age)
        {
            this.daysAdmitted = daysAdmitted;
        }

        public override double CalculateBill()
        {
            return daysAdmitted * dailyCharge;
        }

        public void AddRecord(string record)
        {
            medicalRecords.Add(record);
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical Records:");
            foreach (var record in medicalRecords)
            {
                Console.WriteLine(record);
            }
        }
    }

    // OutPatient subclass
    class OutPatient : Patient, IMedicalRecord
    {
        private double consultationFee = 100;
        private List<string> medicalRecords = new List<string>();

        public OutPatient(string patientId, string name, int age)
            : base(patientId, name, age) { }

        public override double CalculateBill()
        {
            return consultationFee;
        }

        public void AddRecord(string record)
        {
            medicalRecords.Add(record);
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical Records:");
            foreach (var record in medicalRecords)
            {
                Console.WriteLine(record);
            }
        }
    }

    class HospitalManagement
    {
        static void Main()
        {
            Console.WriteLine("Enter Patient Type (1 for InPatient, 2 for OutPatient): ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter Patient ID: ");
            string patientId = Console.ReadLine();

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Patient patient;

            if (choice == 1)
            {
                Console.Write("Enter Days Admitted: ");
                int daysAdmitted = int.Parse(Console.ReadLine());
                patient = new InPatient(patientId, name, age, daysAdmitted);
            }
            else
            {
                patient = new OutPatient(patientId, name, age);
            }

            patient.GetPatientDetails();
            Console.WriteLine($"Total Bill: {patient.CalculateBill()}");

            if (patient is IMedicalRecord medicalRecord)
            {
                Console.Write("Enter a Medical Record to add: ");
                string record = Console.ReadLine();
                medicalRecord.AddRecord(record);
                Console.WriteLine("Viewing Medical Records:");
                medicalRecord.ViewRecords();
            }
        }
    }
}
