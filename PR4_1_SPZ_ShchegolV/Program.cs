using System;

namespace UniversityApp
{
    class University
    {
        public string Name;
        public int FoundationYear;
        public int NumberOfGraduates;
        public string Type;
        public bool HasDoctoralPrograms;
        public bool HasSportsComplex;
        public string Ownership;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Enter the university name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the foundation year: ");
            int foundationYear = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of graduates: ");
            int numberOfGraduates = int.Parse(Console.ReadLine());

            Console.Write("Enter the university type (medical, economic, technical, financial, etc.): ");
            string type = Console.ReadLine();

            Console.Write("Does the university have doctoral programs (true/false): ");
            bool hasDoctoralPrograms = bool.Parse(Console.ReadLine());

            Console.Write("Does the university have a sports complex (true/false): ");
            bool hasSportsComplex = bool.Parse(Console.ReadLine());

            Console.Write("Enter the university ownership (public/private): ");
            string ownership = Console.ReadLine();

            University university = new University();
            university.Name = name;
            university.FoundationYear = foundationYear;
            university.NumberOfGraduates = numberOfGraduates;
            university.Type = type;
            university.HasDoctoralPrograms = hasDoctoralPrograms;
            university.HasSportsComplex = hasSportsComplex;
            university.Ownership = ownership;

            Console.WriteLine();
            Console.WriteLine("~University Information~");
            Console.WriteLine();
            Console.WriteLine($"Name: {FormatUniversityName(university)}");
            Console.WriteLine($"Foundation Year: {university.FoundationYear}");
            Console.WriteLine($"Number of Graduates: {university.NumberOfGraduates}");
            Console.WriteLine($"Type: {university.Type}");
            Console.WriteLine($"Has Doctoral Programs: {(university.HasDoctoralPrograms ? "Yes" : "No")}");
            Console.WriteLine($"Has Sports Complex: {(university.HasSportsComplex ? "Yes" : "No")}");
            Console.WriteLine($"Ownership: {university.Ownership}");

            double averageGraduatesPerYear = GetAverageGraduatesPerYear(university);
            Console.WriteLine($"Average Graduates Per Year: {averageGraduatesPerYear}");
        }

        static string FormatUniversityName(University university)
        {
            switch (university.Type)
            {
                case "medical":
                    return $"\u001b[1;31m{university.Name}\u001b[0m";
                case "economic":
                    return $"\u001b[1;33m{university.Name}\u001b[0m";
                case "technical":
                    return $"\u001b[1;34m{university.Name}\u001b[0m";
                case "financial":
                    return $"\u001b[1;32m{university.Name}\u001b[0m";
                default:
                    return university.Name;

            }
        }

        static double GetAverageGraduatesPerYear(University university)
        {
            int yearsOfOperation = DateTime.Now.Year - university.FoundationYear;

            if (yearsOfOperation > 0)
            {
                return (double)university.NumberOfGraduates / yearsOfOperation;
            }
            else
            {
                return 0;
            }
        }
    }
}
