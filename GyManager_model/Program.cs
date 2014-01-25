using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GyManager
{
    public class Program
    {
        public string name { get; set; }
        public int price { get; set; }
        public int places_available { get; set; }
        public int places_taken { get; set; }
        public string instructor { get; set; } //jmbg
        public int salary { get; set; }

        public Program(string inName, int inPrice, int inPlacesAvailable, string inInstructor, int inSalary)
        {
            name = inName;
            price = inPrice;
            places_available = inPlacesAvailable;
            places_taken = 0;
            instructor = inInstructor;
            salary = inSalary;
        }

        public void NewMemberHasEnrolled()
        {
            places_available -= 1;
            places_taken += 1;
        }

        public void MemberHasUnenrolled()
        {
            places_available += 1;
            places_taken -= 1;
        }
    }
}
