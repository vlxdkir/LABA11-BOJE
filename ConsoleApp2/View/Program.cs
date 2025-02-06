using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalEmployees
{
    class Program
    {
        static List<HospitalEmployee> employees = new List<HospitalEmployee>();

        public static List<HospitalEmployee> Employees { get => employees; set => employees = value; }

        static void Main(string[] args)
        {
            string key;
            key = keymethod();
        }
        //Изменения 2
        //новая ветка
        private static string keymethod()
        {
            string key;
            do
            {
                Console.WriteLine("\n*** Больница - система управления персоналом ***");
                Console.WriteLine("1 - Добавить сотрудника");
                Console.WriteLine("2 - Показать всех сотрудников");
                Console.WriteLine("3 - Найти сотрудника по имени");
                Console.WriteLine("4 - Выход");
                Console.Write("Выберите действие: ");

                key = Console.ReadLine();

                switch (key)
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        ShowAllEmployees();
                        break;
                    case "3":
                        SearchEmployee();
                        break;
                    case "4":
                        Console.WriteLine("Выход из программы...");
                        break;
                    default:
                        Console.WriteLine("Неверный ввод!");
                        break;
                }
            } while (key != "4");
            return key;
        }

        static void AddEmployee()
        {
            Console.WriteLine("\nВыберите тип сотрудника:");
            Console.WriteLine("1 - Обычный сотрудник");
            Console.WriteLine("2 - Медсестра");
            Console.WriteLine("3 - Хирург");
            Console.Write("Ваш выбор: ");

            string type = Console.ReadLine();

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            int age;
            while (true)
            {
                Console.Write("Введите возраст: ");
                if (!int.TryParse(Console.ReadLine(), out age) || age <= 18 || age >= 70)
                    Console.WriteLine("Некорректный возраст! Допустимый диапазон: 18-70");
                else
                    break;
            }

            switch (type)
            {
                case "1":
                    Employees.Add(new HospitalEmployee(name, age));
                    break;
                case "2":
                    Employees.Add(new Nurse(name, age));
                    break;
                case "3":
                    Employees.Add(new Surgeon(name, age));
                    break;
                default:
                    Console.WriteLine("Неверный тип сотрудника!");
                    break;
            }
            Console.WriteLine("Сотрудник успешно добавлен!");
        }

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
