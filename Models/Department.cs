using System;
using System.Collections.Generic;
using System.Text;

namespace University_Simulation.Models
{
    class Department
    {
        public string _Name { get; set; }
        public int _MidtermScoreRatio { get; set; }
        public int _FinalScoreRatio { get; set; }
        public int _MinimumPassingScore { get; set; }
        public string _UniversityName { get; set; }
        public Department(string line)
        {
            
        }
        public void FullName()
        {
            Console.WriteLine($"{_UniversityName} {_Name} Department");
        }
    }
    
}
