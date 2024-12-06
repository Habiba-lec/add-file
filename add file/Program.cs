using System;
using System.Collections.Generic;
using System.IO;

namespace CSVPolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "data.csv"; // CSV file in the project directory
            List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();

            // Step 1: Read the CSV file
            var lines = File.ReadAllLines(filePath);
            var headers = lines[0].Split(','); // Extract the headers

            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');
                var row = new Dictionary<string, string>();
                for (int j = 0; j < headers.Length; j++)
                {
                    row[headers[j]] = values[j];
                }
                dataList.Add(row);
            }

            // Step 2: Create a list of Employee objects
            List<Employee> employees = new List<Employee>();

            foreach (var row in dataList)
            {
                string name = row["Name"];
                string role = row["Role"];

                Employee employee = role switch
                {
                    "Manager" => new Manager(name),
                    "Developer" => new Developer(name),
                    "Intern" => new Intern(name),
                    _ => new Employee(name) // Default to base class
                };

                employees.Add(employee);
            }

            // Step 3: Call GetDetails dynamically
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.GetDetails());
            }
        }
    }
}
