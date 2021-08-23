﻿using System;
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

            //Persons
            string[] PersonCsv = System.IO.File.
                ReadAllLines(@"C:\Users\hyalc\source\repos\University Simulation\Assets\Person.csv");            
            foreach (string line in PersonCsv)
            {
                string[] parameter = line.Split(',');
                
                if (parameter[2] == "Teacher")
                {
                    Teacher newPerson = new Teacher(parameter);

                    Persons.Add(newPerson);
                    Teachers.Add(newPerson);                               
                }
                else if (parameter[2] == "Student")
                {
                    Student newPerson = new Student(parameter);

                    Persons.Add(newPerson);
                    Students.Add(newPerson);
                }
            }

            //University
            string[] UniversityCsv = System.IO.File.
                ReadAllLines(@"C:\Users\hyalc\source\repos\University Simulation\Assets\University.csv");

            foreach (string line in UniversityCsv)
            {
                University uni = new University(line);
                Universities.Add(uni);
            }

            //Department 
            string[] DepartmentCsv = System.IO.File.
                ReadAllLines(@"C:\Users\hyalc\source\repos\University Simulation\Assets\Department.csv");
            
            foreach (string line in DepartmentCsv)
            {
                
                Department newDepartment = new Department(line,Students,Teachers);
                Deparments.Add(newDepartment);
                Console.WriteLine(line);
            }
        }
    }
}
