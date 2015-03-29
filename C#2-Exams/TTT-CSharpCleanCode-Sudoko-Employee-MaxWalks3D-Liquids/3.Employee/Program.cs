using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Employee
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Rank { get; set; }
        public string Position { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, int> posAndRank = new Dictionary<string, int>();

            int numberOfPositions = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPositions; i++)
            {
                string line = Console.ReadLine();
                string[] rawInput = line.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                if (!posAndRank.ContainsKey(rawInput[0]))
                {
                posAndRank.Add(rawInput[0], int.Parse(rawInput[1]));
                    
                }
            }
            int numbersOfWorkers = int.Parse(Console.ReadLine());
            List<Employee> allWorkers = new List<Employee>();

            for (int i = 0; i < numbersOfWorkers; i++)
            {
                string line = Console.ReadLine();
                string[] rawInput = line.Split(new string[] { " - " },StringSplitOptions.RemoveEmptyEntries);
                Employee currentEmployee = new Employee();
                string[] splitedName = rawInput[0].Split();
                currentEmployee.FirstName= splitedName[0];
                currentEmployee.LastName = splitedName[1];
                currentEmployee.Position = rawInput[1]; 
                currentEmployee.Rank = posAndRank[currentEmployee.Position];
                allWorkers.Add(currentEmployee);
            }
            var sortedWorkers = allWorkers
                .OrderByDescending(em => em.Rank)
                .ThenBy(em => em.LastName)
                .ThenBy(em => em.FirstName);
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine("{0} {1}",worker.FirstName , worker.LastName);
            }
        }
    }
}
