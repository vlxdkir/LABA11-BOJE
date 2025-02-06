using HospitalEmployees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Services
{
    public class Service
    {
        static List<HospitalEmployee> employees = new List<HospitalEmployee>();

        public static List<HospitalEmployee> Employees { get => employees; set => employees = value; }

        static void ShowAllEmployees()
        {
            if (Employees.Count == 0)
            {
                Console.WriteLine("\nСписок сотрудников пуст!");
                return;
            }

            Console.WriteLine("\nСписок всех сотрудников:");
            foreach (var employee in Employees)
            {
                employee.PrintInfo();
                Console.WriteLine("----------------------");
            }
        }

        static void SearchEmployee()
        {
            Console.Write("\nВведите имя для поиска: ");
            string searchName = Console.ReadLine();
            bool found = false;

            foreach (var employee in Employees)
            {
                if (employee.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    employee.PrintInfo();
                    Console.WriteLine("----------------------");
                    found = true;
                }
            }

            if (!found) Console.WriteLine("Сотрудники с таким именем не найдены!");
        }
    }
}

