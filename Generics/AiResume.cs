using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{


   

    // Abstract Job Position
    public abstract class JobPosition
    {
        public string ApplicantName { get; private set; }
        public int WorkExperience { get; private set; }

        public JobPosition(string applicantName, int workExperience)
        {
            ApplicantName = applicantName;
            WorkExperience = workExperience;
        }

        public abstract void ShowPositionDetails();
    }

    // Software Developer Position
    public class SoftwareDeveloper : JobPosition
    {
        public string TechStack { get; private set; }

        public SoftwareDeveloper(string applicantName, int workExperience, string techStack)
            : base(applicantName, workExperience)
        {
            TechStack = techStack;
        }

        public override void ShowPositionDetails()
        {
            Console.WriteLine($"[Software Developer] Applicant: {ApplicantName}, Experience: {WorkExperience} years, Technology: {TechStack}");
        }
    }

    // Data Analyst Position
    public class DataAnalyst : JobPosition
    {
        public string AnalysisTool { get; private set; }

        public DataAnalyst(string applicantName, int workExperience, string analysisTool)
            : base(applicantName, workExperience)
        {
            AnalysisTool = analysisTool;
        }

        public override void ShowPositionDetails()
        {
            Console.WriteLine($"[Data Analyst] Applicant: {ApplicantName}, Experience: {WorkExperience} years, Tool: {AnalysisTool}");
        }
    }

    // Generic Resume Handler with Constraint on JobPosition
    public class ResumeHandler<T> where T : JobPosition
    {
        private List<T> resumeCollection = new List<T>();

        public void AddApplicantResume(T resume)
        {
            resumeCollection.Add(resume);
        }

        public void DisplayAllResumes()
        {
            foreach (var resume in resumeCollection)
            {
                resume.ShowPositionDetails();
            }
        }
    }

    // Generic Resume Processing Utility
    public static class ResumeUtility
    {
        public static void EvaluateResume<T>(ResumeHandler<T> resumeHandler, T resume) where T : JobPosition
        {
            if (resume.WorkExperience < 1)
            {
                Console.WriteLine($"Warning: {resume.ApplicantName} has less than 1 year of experience.");
            }

            resumeHandler.AddApplicantResume(resume);
            Console.WriteLine($"Resume added for {resume.ApplicantName}");
        }
    }

    // Main Execution
    class Program
    {
        static void Main()
        {
            // Resume handlers for different job positions
            ResumeHandler<SoftwareDeveloper> softwareResumes = new ResumeHandler<SoftwareDeveloper>();
            ResumeHandler<DataAnalyst> dataResumes = new ResumeHandler<DataAnalyst>();

            // Create resume instances
            SoftwareDeveloper applicant1 = new SoftwareDeveloper("Alice Johnson", 5, "C#");
            DataAnalyst applicant2 = new DataAnalyst("Bob Smith", 3, "Python");

            // Process resumes using the generic method
            ResumeUtility.EvaluateResume(softwareResumes, applicant1);
            ResumeUtility.EvaluateResume(dataResumes, applicant2);

            // Display all resumes
            Console.WriteLine("\n--- Software Developer Resumes ---");
            softwareResumes.DisplayAllResumes();

            Console.WriteLine("\n--- Data Analyst Resumes ---");
            dataResumes.DisplayAllResumes();
        }
    }


}
