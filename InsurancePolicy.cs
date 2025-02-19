using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{
   
    public class InsurancePolicy
    {
        public string PolicyNumber { get; set; }
        public string CoverageType { get; set; }
        public DateTime ExpiryDate { get; set; }

        public InsurancePolicy(string policyNumber, string coverageType, DateTime expiryDate)
        {
            PolicyNumber = policyNumber;
            CoverageType = coverageType;
            ExpiryDate = expiryDate;
        }

        public override bool Equals(object obj)
        {
            return obj is InsurancePolicy policy &&
                   PolicyNumber == policy.PolicyNumber;
        }

        public override int GetHashCode()
        {
            return PolicyNumber.GetHashCode();
        }

        public override string ToString()
        {
            return $"PolicyNumber: {PolicyNumber}, CoverageType: {CoverageType}, ExpiryDate: {ExpiryDate.ToShortDateString()}";
        }
    }

    public class InsurancePolicyManagementSystem
    {
        // HashSet for quick lookups (unique policies)
        private HashSet<InsurancePolicy> uniquePolicies = new HashSet<InsurancePolicy>();

        // LinkedHashSet (simulated using a List with order of insertion preserved)
        private List<InsurancePolicy> orderedPolicies = new List<InsurancePolicy>();

        // SortedSet for policies sorted by expiry date (TreeSet equivalent)
        private SortedSet<InsurancePolicy> sortedPolicies = new SortedSet<InsurancePolicy>(
            new Comparison<InsurancePolicy>((x, y) => x.ExpiryDate.CompareTo(y.ExpiryDate))
        );

        public void AddPolicy(InsurancePolicy policy)
        {
            if (uniquePolicies.Add(policy))
            {
                orderedPolicies.Add(policy);
                sortedPolicies.Add(policy);
            }
        }

        public IEnumerable<InsurancePolicy> GetAllPolicies()
        {
            return uniquePolicies;
        }

        public IEnumerable<InsurancePolicy> GetPoliciesExpiringSoon()
        {
            DateTime thirtyDaysFromNow = DateTime.Now.AddDays(30);
            return sortedPolicies.Where(p => p.ExpiryDate <= thirtyDaysFromNow);
        }

        public IEnumerable<InsurancePolicy> GetPoliciesByCoverageType(string coverageType)
        {
            return uniquePolicies.Where(p => p.CoverageType.Equals(coverageType, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<InsurancePolicy> GetDuplicatePolicies()
        {
            var duplicates = uniquePolicies
                .GroupBy(p => p.PolicyNumber)
                .Where(g => g.Count() > 1)
                .SelectMany(g => g);
            return duplicates;
        }

        public IEnumerable<InsurancePolicy> GetPoliciesInInsertionOrder()
        {
            return orderedPolicies;
        }

        public IEnumerable<InsurancePolicy> GetSortedPoliciesByExpiryDate()
        {
            return sortedPolicies;
        }
    }

    class Insurance
    {
        static void Main()
        {
            var system = new InsurancePolicyManagementSystem();

            var policy1 = new InsurancePolicy("P001", "Health", new DateTime(2025, 5, 30));
            var policy2 = new InsurancePolicy("P002", "Life", new DateTime(2025, 4, 15));
            var policy3 = new InsurancePolicy("P003", "Auto", new DateTime(2025, 6, 20));
            var policy4 = new InsurancePolicy("P004", "Health", new DateTime(2025, 2, 10));
            var policy5 = new InsurancePolicy("P001", "Health", new DateTime(2025, 5, 30)); // Duplicate Policy

            system.AddPolicy(policy1);
            system.AddPolicy(policy2);
            system.AddPolicy(policy3);
            system.AddPolicy(policy4);
            system.AddPolicy(policy5); // Will not be added due to duplicate

            Console.WriteLine("All Unique Policies:");
            foreach (var policy in system.GetAllPolicies())
            {
                Console.WriteLine(policy);
            }

            Console.WriteLine("\nPolicies Expiring Soon:");
            foreach (var policy in system.GetPoliciesExpiringSoon())
            {
                Console.WriteLine(policy);
            }

            Console.WriteLine("\nPolicies by Coverage Type (Health):");
            foreach (var policy in system.GetPoliciesByCoverageType("Health"))
            {
                Console.WriteLine(policy);
            }

            Console.WriteLine("\nDuplicate Policies:");
            foreach (var policy in system.GetDuplicatePolicies())
            {
                Console.WriteLine(policy);
            }

            Console.WriteLine("\nPolicies in Insertion Order:");
            foreach (var policy in system.GetPoliciesInInsertionOrder())
            {
                Console.WriteLine(policy);
            }

            Console.WriteLine("\nPolicies Sorted by Expiry Date:");
            foreach (var policy in system.GetSortedPoliciesByExpiryDate())
            {
                Console.WriteLine(policy);
            }
        }
    }

}
