using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{
    

    class HospitalTriageSystem
    {
        // Define a class to represent a patient
        public class Patient
        {
            public string FullName { get; set; }
            public int CriticalityLevel { get; set; }

            public Patient(string fullName, int criticalityLevel)
            {
                FullName = fullName;
                CriticalityLevel = criticalityLevel;
            }
        }

        // Define a comparer to prioritize patients with higher criticality
        public class CriticalityComparer : IComparer<Patient>
        {
            public int Compare(Patient a, Patient b)
            {
                // Higher criticality should come first, so we reverse the comparison
                return b.CriticalityLevel.CompareTo(a.CriticalityLevel);
            }
        }

        public static void SimulateTriageProcedure(List<Patient> patientList)
        {
            // Create a priority queue with the custom comparer for patients
            PriorityQueue<Patient, int> priorityQueue = new PriorityQueue<Patient, int>(new CriticalityComparer());

            // Enqueue all patients into the priority queue
            foreach (var patient in patientList)
            {
                priorityQueue.Enqueue(patient, patient.CriticalityLevel);
            }

            // Process the patients in order of criticality (higher first)
            Console.WriteLine("Treatment Order:");
            while (priorityQueue.Count > 0)
            {
                // Dequeue and treat the patient with the highest criticality
                var patient = priorityQueue.Dequeue();
                Console.WriteLine(patient.FullName);
            }
        }

        static void Main()
        {
            // Example patients with full name and criticality level
            List<Patient> patientList = new List<Patient>
        {
            new Patient("John", 3),
            new Patient("Alice", 5),
            new Patient("Bob", 2)
        };

            // Simulate the triage procedure
            SimulateTriageProcedure(patientList);
        }
    }

}
