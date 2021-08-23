using System;
using System.Collections.Generic;
using System.Text;

namespace University_Simulation.Models
{
    public class Student : Person
    {
        public int _MidtermScore { get; set; }
        public int _FinalScore { get; set; }
        public List<Department> _Departments { get; set; }
        


        public Student(string[] parameter, List<Department> Deparments) : base(parameter[0], parameter[1], parameter[2], parameter[3])
        {
            _Departments = Deparments;
            _MidtermScore = Int32.Parse(parameter[5]);
            _FinalScore = Int32.Parse(parameter[6]);
            

        }
        public int AverageScore()
        {
            return 1;
        }
        public bool IsPassed()
        {
            return true;
        }
        public void Work()
        {
            Console.WriteLine("Studying");
        }
    }
}
