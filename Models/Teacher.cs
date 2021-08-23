using System;
using System.Collections.Generic;
using System.Text;

namespace University_Simulation.Models
{
    public class Teacher : Person
    {
        public string _FieldOfStudy { get; set; }

        public Teacher(string[] parameter) : base(parameter[0], parameter[1], parameter[2], parameter[3])
        {
            _FieldOfStudy = parameter[7];

        }
        public void Work()
        {
            Console.WriteLine("Teaching");
        }
    }
}
