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

        public University(string line,List<Department> departments)
        {
            string[] parameters = line.Split(',');
            _Name = parameters[0];
            _DataOfEstablishment = Int32.Parse(parameters[1]);

            _Departments = departments.FindAll(x => x._UniversityName == this._Name);

                     
        }
        void Students()
        {

        }
        void Teachers()
        {

        }
    }
}
