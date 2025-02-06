using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalEmployees
{
    public class HospitalEmployee
    {
        private string name1;
        private int age;

        public virtual string Position => "Работник больницы";
        public string Name => Name1;

        protected string Name1 { get => name1; set => name1 = value; }
        protected int Age { get => age; set => age = value; }

        public HospitalEmployee(string name, int age)
        {
            this.Name1 = name;
            this.Age = age;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Должность: {Position}\nИмя: {Name1}\nВозраст: {Age}");
        }
    }
}
