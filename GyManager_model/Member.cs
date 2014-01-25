using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GyManager
{
    public class Member
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string jmbg { get; set; }
        public List<string> programs { get; set; }
        public int membership { get; set; }
        public DateTime last_payment { get; set; }

        public Member(string inName, string inSurname, string inJmbg)
        {
            name = inName;
            surname = inSurname;
            jmbg = inJmbg;
            programs = new List<string>();
            membership = 0;
        }
    }


}
