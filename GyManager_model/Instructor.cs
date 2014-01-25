using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GyManager
{
    public class Instructor
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string jmbg { get; set; }
        public DateTime last_payment { get; set; }
        public string program { get; set; }

        public Instructor(string inName, string inSurname, string inJmbg, string inProgram)
        {
            name = inName;
            surname = inSurname;
            jmbg = inJmbg;
            program = inProgram;
        }
    }
}
