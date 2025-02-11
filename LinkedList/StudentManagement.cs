//namespace LinkedList
//{
//    using System;

//    class Student
//    {
//        public int RollNumber;
//        public string Name;
//        public int Age;
//        public char Grade;
//        public Student Next;

//        public Student(int rollNumber, string name, int age, char grade)
//        {
//            RollNumber = rollNumber;
//            Name = name;
//            Age = age;
//            Grade = grade;
//            Next = null;
//        }
//    }

//    class StudentList
//    {
//        private Student head;

//        public void AddStudentAtBeginning(int rollNumber, string name, int age, char grade)
//        {
//            Student newStudent = new Student(rollNumber, name, age, grade);
//            newStudent.Next = head;
//            head = newStudent;
//        }

//        public void AddStudentAtEnd(int rollNumber, string name, int age, char grade)
//        {
//            Student newStudent = new Student(rollNumber, name, age, grade);
//            if (head == null)
//            {
//                head = newStudent;
//                return;
//            }
//            Student temp = head;
//            while (temp.Next != null)
//            {
//                temp = temp.Next;
//            }
//            temp.Next = newStudent;
//        }

//        public void AddStudentAtPosition(int rollNumber, string name, int age, char grade, int pos)
//        {
//            if (pos < 1)
//            {
//                Console.WriteLine("Invalid position!");
//                return;
//            }
//            Student newStudent = new Student(rollNumber, name, age, grade);
//            if (pos == 1)
//            {
//                newStudent.Next = head;
//                head = newStudent;
//                return;
//            }
//            Student temp = head;
//            for (int i = 1; temp != null && i < pos - 1; i++)
//            {
//                temp = temp.Next;
//            }
//            if (temp == null)
//            {
//                Console.WriteLine("Position out of bounds.");
//                return;
//            }
//            newStudent.Next = temp.Next;
//            temp.Next = newStudent;
//        }

//        public void DeleteStudentByRollNumber(int rollNumber)
//        {
//            if (head == null)
//            {
//                Console.WriteLine("List is empty.");
//                return;
//            }
//            if (head.RollNumber == rollNumber)
//            {
//                head = head.Next;
//                return;
//            }
//            Student temp = head, prev = null;
//            while (temp != null && temp.RollNumber != rollNumber)
//            {
//                prev = temp;
//                temp = temp.Next;
//            }
//            if (temp == null)
//            {
//                Console.WriteLine("Student not found.");
//                return;
//            }
//            prev.Next = temp.Next;
//        }

//        public Student SearchStudent(int rollNumber)
//        {
//            Student temp = head;
//            while (temp != null)
//            {
//                if (temp.RollNumber == rollNumber)
//                    return temp;
//                temp = temp.Next;
//            }
//            return null;
//        }

//        public void DisplayStudents()
//        {
//            Student temp = head;
//            while (temp != null)
//            {
//                Console.WriteLine($"Roll: {temp.RollNumber}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
//                temp = temp.Next;
//            }
//        }

//        public void UpdateStudentGrade(int rollNumber, char newGrade)
//        {
//            Student student = SearchStudent(rollNumber);
//            if (student != null)
//            {
//                student.Grade = newGrade;
//                Console.WriteLine("Grade updated successfully.");
//            }
//            else
//            {
//                Console.WriteLine("Student not found.");
//            }
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            StudentList studentList = new StudentList();

//            studentList.AddStudentAtEnd(1, "Alice", 20, 'A');
//            studentList.AddStudentAtEnd(2, "Bob", 22, 'B');
//            studentList.AddStudentAtBeginning(3, "Charlie", 21, 'C');

//            Console.WriteLine("All Students:");
//            studentList.DisplayStudents();

//            Console.WriteLine("\nUpdating Grade for Roll Number 2:");
//            studentList.UpdateStudentGrade(2, 'A');
//            studentList.DisplayStudents();

//            Console.WriteLine("\nDeleting Student with Roll Number 1:");
//            studentList.DeleteStudentByRollNumber(1);
//            studentList.DisplayStudents();

//            Console.WriteLine("\nSearching for Student with Roll Number 3:");
//            Student foundStudent = studentList.SearchStudent(3);
//            if (foundStudent != null)
//                Console.WriteLine($"Found: Roll: {foundStudent.RollNumber}, Name: {foundStudent.Name}, Age: {foundStudent.Age}, Grade: {foundStudent.Grade}");
//            else
//                Console.WriteLine("Student not found.");
//        }
//    }

//}
