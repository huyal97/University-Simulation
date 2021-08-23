using System;
using System.Collections.Generic;
using System.Text;

namespace University_Simulation.Models
{
    public class Person
    {
        public string _Name { get; set; }
        public string _Surname { get; set; }
        public string _Role { get; set; }
        public string _DepartmentName { get; set; }

        public Person(string Name, string Surname, string Role, string Department)
        {
            _Name = Name;
            _Surname = Surname;
            _Role = Role;
            _DepartmentName = Department;
        }
        public void Fullname()
        {
            Console.WriteLine($"{_Name} {_Surname}");
        }
    }
}
