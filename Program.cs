using System;
using System.Collections.Generic;
using University_Simulation.Models;

namespace University_Simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var Deparments = new List<Department>();
            var Persons = new List<Person>();
            var Students = new List<Student>();
            var Teachers = new List<Teacher>();
            var Universities = new List<University>();

            string[] DepartmentCsv = System.IO.File.
                ReadAllLines(@"C:\Users\hyalc\source\repos\University Simulation\Assets\Department.csv");
            var Deparments = new List<Department>();
            foreach (string line in DepartmentCsv)
            {

                Department newDepartment = new Department(line);
                Deparments.Add(newDepartment);
                Console.WriteLine(line);

            }



        }
    }
}
