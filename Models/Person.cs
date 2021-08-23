using System;
using System.Collections.Generic;
using System.Text;

namespace University_Simulation.Models
{
    class Person
    {
        public string _Name { get; set; }
        public string _Surname { get; set; }
        public string _Role { get; set; }
        public string _Department { get; set; }

        public Person()
        {
            
        }
        public void Fullname()
        {
            Console.WriteLine($"{_Name} {_Surname}");
        }
    }
}
