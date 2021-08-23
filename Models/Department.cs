using System;
using System.Collections.Generic;
using System.Text;

namespace University_Simulation.Models
{
    public class Department
    {
        public string _Name { get; set; }
        public int _MidtermScoreRatio { get; set; }
        public int _FinalScoreRatio { get; set; }
        public int _MinimumPassingScore { get; set; }
        public string _UniversityName { get; set; }
        public List<Student> _Students { get; set; }
        public List<Teacher> _Teachers { get; set; }

        public Department(string line, List<Student> students, List<Teacher> teachers)
        {
            _Students = students.FindAll(x => x._DepartmentName == this._Name);
            _Teachers = teachers.FindAll(x => x._DepartmentName == this._Name);

            string[] parameters = line.Split(",");

            _Name = parameters[0];
            _MidtermScoreRatio = Int32.Parse(parameters[1]);
            _FinalScoreRatio = Int32.Parse(parameters[2]);
            _MinimumPassingScore = Int32.Parse(parameters[3]);
            _UniversityName = parameters[4];
        }
        public void FullName()
        {
            Console.WriteLine($"{_UniversityName} {_Name} Department");
        }
    }
    
}
