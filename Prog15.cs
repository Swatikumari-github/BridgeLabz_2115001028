

namespace CSV
{


    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;

    class Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Salary { get; set; }
        public string Email { get; set; }

        public Employee(string id, string name, int age, string salary, string email)
        {
            ID = id;
            Name = name;
            Age = age;
            Salary = salary;
            Email = email;
        }
    }

    class CSVEncryptDecrypt
    {
        private static string key = "1234567890123456"; // 16 bytes key for AES encryption
        private static string iv = "abcdef9876543210";  // 16 bytes IV for AES encryption

        // Encrypt data using AES
        public static string Encrypt(string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = Encoding.UTF8.GetBytes(iv);

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        // Decrypt data using AES
        public static string Decrypt(string cipherText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = Encoding.UTF8.GetBytes(iv);

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

        // Write encrypted data to CSV
        public static void WriteEncryptedCSV(string filePath, List<Employee> employees)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("ID,Name,Age,Salary,Email"); // CSV Header
                    foreach (var employee in employees)
                    {
                        string encryptedSalary = Encrypt(employee.Salary);
                        string encryptedEmail = Encrypt(employee.Email);

                        writer.WriteLine($"{employee.ID},{employee.Name},{employee.Age},{encryptedSalary},{encryptedEmail}");
                    }
                }

                Console.WriteLine("Encrypted CSV file created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing encrypted CSV: " + ex.Message);
            }
        }

        // Read and decrypt data from CSV
        public static void ReadDecryptedCSV(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    reader.ReadLine(); // Skip header

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] fields = line.Split(',');

                        string id = fields[0];
                        string name = fields[1];
                        int age = int.Parse(fields[2]);
                        string decryptedSalary = Decrypt(fields[3]);
                        string decryptedEmail = Decrypt(fields[4]);

                        Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}, Salary: {decryptedSalary}, Email: {decryptedEmail}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading decrypted CSV: " + ex.Message);
            }
        }
    }

    class Prog15
    {
        static void Main()
        {
            // Sample Employee data
            List<Employee> employees = new List<Employee>
        {
            new Employee("101", "John Doe", 25, "60000", "johndoe@example.com"),
            new Employee("102", "Jane Smith", 28, "75000", "janesmith@example.com"),
            new Employee("103", "Mark Johnson", 30, "80000", "mark.johnson@example.com")
        };

            string encryptedCSVPath = "encrypted_employees.csv";
            string decryptedCSVPath = "decrypted_employees.csv";

            // Write encrypted CSV
            CSVEncryptDecrypt.WriteEncryptedCSV(encryptedCSVPath, employees);

            // Read decrypted CSV
            Console.WriteLine("\nDecrypted Employee Data:");
            CSVEncryptDecrypt.ReadDecryptedCSV(encryptedCSVPath);
        }
    }

}

