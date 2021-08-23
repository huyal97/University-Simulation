using System;
using System.Collections.Generic;
using System.Text;

namespace University_Simulation.Models
{
    public class University
    {
        public string _Name { get; set; }
        public int _DataOfEstablishment { get; set; }
        

        public University(string line)
        {
            string[] parameters = line.Split(',');
            _Name = parameters[0];
            _DataOfEstablishment = Int32.Parse(parameters[1]);          
        }
        void Students()
        {

        }
        void Teachers()
        {

        }
    }
}
