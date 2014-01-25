using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GyManager_observer;

namespace GyManager
{
    public static class Factory
    {
        private static GyManager _gymanager;

        public static GyManager GyManager
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public static IGyManager CreateGyManager()
        {
            if (_gymanager == null)
            {
                _gymanager = new GyManager();
                return _gymanager;
            }
            else
            {
                return _gymanager;
            }
        }

        public static IGyManager CreateGyManagerForTests()
        {
            return new GyManager();
        }
    }

    public class GyManager : Subject, IGyManager
    {
        public int cash_register { get; set; }

        public Instructor Instructor
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Member Member
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Program Program
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public Dictionary<string, Member> members = new Dictionary<string, Member>();
        public Dictionary<string, Instructor> instructors = new Dictionary<string, Instructor>();
        public Dictionary<string, Program> programs = new Dictionary<string, Program>();

        public GyManager()
        {
            cash_register = 10000;
            AddProgramAndInstructor("Aerobic", 120, 20, "Renata", "Sopek", "1111111111110", 1000);
            AddProgramAndInstructor("Kick-boxing", 100, 20, "Jillian", "Michaels", "1111111111111", 2000);
            AddProgramAndInstructor("Pilates", 100, 25, "Eva", "Longoria", "1111111111112", 1200);
            AddProgramAndInstructor("Yogalates", 200, 20, "Miranda", "Kerr", "1111111111113", 5000);
            AddProgramAndInstructor("Yoga", 300, 10, "Gwyneth", "Paltrow", "1111111111114", 5000);
            AddMember("Vlatka", "Pavišić", "2209990335110");
            EnrollANewProgram("Kick-boxing", "2209990335110");
            AddMember("Lana", "Del Rey", "1111111111115");
            EnrollANewProgram("Kick-boxing", "1111111111115");
            EnrollANewProgram("Yogalates", "1111111111115");
            AddMember("Coco", "Chanel", "1111111111116");
            EnrollANewProgram("Yoga", "1111111111116");
            AddMember("Ada", "Lovelace", "1111111111117");
            EnrollANewProgram("Yoga", "1111111111117");
            AddMember("Brigitte", "Bardot", "1111111111118");
            EnrollANewProgram("Yoga", "1111111111118");
            EnrollANewProgram("Pilates", "1111111111118");
            AddMember("Marie", "Antoinette", "1111111111119");
            EnrollANewProgram("Aerobic", "1111111111119");
            AddMember("Carrie", "Bradshaw", "1111111111121");
            EnrollANewProgram("Yoga", "1111111111121");
            EnrollANewProgram("Yogalates", "1111111111121");
            AddMember("Samantha", "Jones", "1111111111122");
            EnrollANewProgram("Yoga", "1111111111122");
            EnrollANewProgram("Yogalates", "1111111111122");
            AddMember("Charlotte", "York", "1111111111123");
            EnrollANewProgram("Yoga", "1111111111123");
            EnrollANewProgram("Yogalates", "1111111111123");
            AddMember("Miranda", "Hobbes", "1111111111124");
            EnrollANewProgram("Yoga", "1111111111124");
            EnrollANewProgram("Yogalates", "1111111111124");

        }

        public void AddMember(string inName, string inSurname, string inJmbg)
        {
            long n;
            if (!long.TryParse(inJmbg, out n)) throw new GyManagerException("JMBG must contain only digits.");
            if (inJmbg.Length != 13) throw new GyManagerException("JMBG must contain 13 digits.");
            if (members.ContainsKey(inJmbg)) throw new GyManagerException("Member with that JMBG already exists.");
            if (instructors.ContainsKey(inJmbg))
                throw new GyManagerException("Person with that JMBG is an instructor.");
            Member newMember = new Member(inName, inSurname, inJmbg);
            members.Add(inJmbg, newMember);
            NotifyObservers();
        }

        public void AddProgramAndInstructor(string inProgramName, int inPrice, int inPlacesAvailable,
            string inInstructorName,
            string inInstructorSurname, string inJmbg, int inSalary)
        {
            long n;
            if (!long.TryParse(inJmbg, out n)) throw new GyManagerException("JMBG must contain only digits.");
            if (inJmbg.Length != 13) throw new GyManagerException("JMBG must contain 13 digits.");
            if (instructors.ContainsKey(inJmbg))
                throw new GyManagerException("Instructor with that JMBG already exists.");
            if (programs.ContainsKey(inProgramName))
                throw new GyManagerException("Program with that name already exists.");
            if (members.ContainsKey(inJmbg)) throw new GyManagerException("Person with that JMBG is a member.");
            Program newProgram = new Program(inProgramName, inPrice, inPlacesAvailable, inJmbg, inSalary);
            programs.Add(inProgramName, newProgram);
            Instructor newInstructor = new Instructor(inInstructorName, inInstructorSurname, inJmbg, inProgramName);
            instructors.Add(inJmbg, newInstructor);
            NotifyObservers();
        }

        public void DeleteMember(string inJmbg)
        {
            long n;
            if (!long.TryParse(inJmbg, out n)) throw new GyManagerException("JMBG must contain only digits.");
            if (inJmbg.Length != 13) throw new GyManagerException("JMBG must contain 13 digits.");
            if (!members.ContainsKey(inJmbg)) throw new GyManagerException("Member with that JMBG doesn't exist.");
            Member member = members[inJmbg];
            foreach (string programName in member.programs)
            {
                programs[programName].MemberHasUnenrolled();
            }
            members.Remove(inJmbg);
            NotifyObservers();
        }

        public void FireInstructorAndHireAnother(string inJmbgFire, string inNameHire, string inSurnameHire,
            string inJmbgHire)
        {
            long n;
            if (!long.TryParse(inJmbgFire, out n) || !long.TryParse(inJmbgHire, out n))
                throw new GyManagerException("JMBG must contain only digits.");
            if (inJmbgFire.Length != 13 || inJmbgHire.Length != 13)
                throw new GyManagerException("JMBG must contain 13 digits.");
            if (members.ContainsKey(inJmbgHire)) throw new GyManagerException("Person with that JMBG is a member.");
            Instructor firedInstructor = instructors[inJmbgFire];
            Instructor hiredInstructor = new Instructor(inNameHire, inSurnameHire, inJmbgHire, firedInstructor.program);
            Program program = programs[firedInstructor.program];
            program.instructor = inJmbgHire;
            instructors.Remove(inJmbgFire);
            instructors.Add(inJmbgHire, hiredInstructor);
            NotifyObservers();
        }

        public void EnrollANewProgram(string inProgramName, string inJmbg)
        {
            long n;
            if (!long.TryParse(inJmbg, out n)) throw new GyManagerException("JMBG must contain only digits.");
            if (inJmbg.Length != 13) throw new GyManagerException("JMBG must contain 13 digits.");
            if (!members.ContainsKey(inJmbg)) throw new GyManagerException("Member with that JMBG doesn't exist.");
            if (!programs.ContainsKey(inProgramName))
                throw new GyManagerException("Program with that name doesn't exist.");
            if (programs[inProgramName].places_available == 0)
                throw new GyManagerException("There's no places available in this program.");
            if (members[inJmbg].programs.Contains(inProgramName))
                throw new GyManagerException("Member is already enrolled in that program.");
            members[inJmbg].programs.Add(inProgramName);
            members[inJmbg].membership += programs[inProgramName].price;
            programs[inProgramName].NewMemberHasEnrolled();
            NotifyObservers();
        }

        public void UnenrollAProgram(string inProgramName, string inJmbg)
        {
            long n;
            if (!long.TryParse(inJmbg, out n)) throw new GyManagerException("JMBG must contain only digits.");
            if (inJmbg.Length != 13) throw new GyManagerException("JMBG must contain 13 digits.");
            if (!members.ContainsKey(inJmbg)) throw new GyManagerException("Member with that JMBG doesn't exist.");
            if (!programs.ContainsKey(inProgramName))
                throw new GyManagerException("Program with that name doesn't exist.");
            if (!members[inJmbg].programs.Contains(inProgramName))
                throw new GyManagerException("Member isn't enrolled in that program.");
            members[inJmbg].programs.Remove(inProgramName);
            members[inJmbg].membership -= programs[inProgramName].price;
            programs[inProgramName].MemberHasUnenrolled();
            NotifyObservers();
        }

        public void PayMembership(string inJmbg)
        {
            long n;
            if (!long.TryParse(inJmbg, out n)) throw new GyManagerException("JMBG must contain only digits.");
            if (inJmbg.Length != 13) throw new GyManagerException("JMBG must contain 13 digits.");
            if (!members.ContainsKey(inJmbg)) throw new GyManagerException("Member with that JMBG doesn't exist.");
            members[inJmbg].last_payment = DateTime.Now;
            cash_register += members[inJmbg].membership;
            NotifyObservers();
        }

        public void PaySalary(string inJmbg)
        {
            long n;
            if (!long.TryParse(inJmbg, out n)) throw new GyManagerException("JMBG must contain only digits.");
            if (inJmbg.Length != 13) throw new GyManagerException("JMBG must contain 13 digits.");
            if (!instructors.ContainsKey(inJmbg))
                throw new GyManagerException("Instructor with that JMBG doesn't exist.");
            instructors[inJmbg].last_payment = DateTime.Now;
            Program program = programs[instructors[inJmbg].program];
            cash_register -= program.salary;
            NotifyObservers();
        }

        public int GetCashRegisterValue()
        {
            return cash_register;
        }

        public List<string> GetMembersPrograms(string inJmbg)
        {
            return members[inJmbg].programs;
        }

        public int GetInstructorsSalary(string inJmbg)
        {
            return programs[instructors[inJmbg].program].salary;
        }

        public int GetMembership(string inJmbg)
        {
            return members[inJmbg].membership;
        }

        public string GetProgramInstructor(string inProgramName)
        {
            return programs[inProgramName].instructor;
        }

        public int GetNumberOfMembersOnAProgram(string inProgramName)
        {
            return programs[inProgramName].places_taken;
        }

        public int GetNumberOfMembers()
        {
            return members.Count;
        }

        public int GetNumberOfInstructors()
        {
            return instructors.Count;
        }

        public int GetNumberOfPrograms()
        {
            return programs.Count;
        }

        public Dictionary<string, Member> GetAllMembers()
        {
            return members;
        }

        public Dictionary<string, Program> GetAllPrograms()
        {
            return programs;
        }

        public Dictionary<string, Instructor> GetAllInstructors()
        {
            return instructors;
        }

        public bool MemberExists(string inJmbg)
        {
            return members.ContainsKey(inJmbg);
        }

        public bool ProgramExists(string inName)
        {
            return programs.ContainsKey(inName);
        }

        public bool InstructorExists(string inJmbg)
        {
            return instructors.ContainsKey(inJmbg);
        }
    }
}
