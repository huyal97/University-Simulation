using System;
using System.Collections.Generic;
using System.Text;

namespace University_Simulation.Models
{
    public class University
    {
        public string _Name { get; set; }
        public int _DataOfEstablishment { get; set; }
        public List<Department> _Departments { get; set; }
        public List<Person> _Persons { get; set; }

        public University(string line,List<Department> departments,List<Person> persons)
        {
            string[] parameters = line.Split(',');
            _Name = parameters[0];
            _DataOfEstablishment = Int32.Parse(parameters[1]);

            _Departments = departments.FindAll(x => x._UniversityName == this._Name);
            _Persons = persons;
        }
        public void Students()
        {
            var students = _Persons.FindAll(x => x._Role == "Student");

            foreach (var student in students)
            {
                student.Fullname();
            }
        }
        public void Teachers()
        {
            var teachers = _Persons.FindAll(x => x._Role == "Teacher");

            foreach (var teacher in teachers)
            {
                teacher.Fullname();
            }
        }
    }
}
