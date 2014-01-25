using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GyManager
{
    public class GyManagerException : Exception
    {
        public string msg { get; set; }
        public GyManagerException(string inMsg)
        {
            msg = inMsg;
        }
    }

    public interface IGyManager
    {
        void AddMember(string inName, string inSurname, string inJmbg);
        void AddProgramAndInstructor(string inProgramName, int inPrice, int inPlacesAvailable, string inInstructorName,
            string inInstructorSurname, string inJmbg, int inSalary);
        void DeleteMember(string inJmbg);
        void FireInstructorAndHireAnother(string inJmbgFire, string inNameHire, string inSurnameHire, string inJmbgHire);
        void EnrollANewProgram(string inProgramName, string inJmbg);
        void UnenrollAProgram(string inProgramName, string inJmbg);
        void PayMembership(string inJmbg);
        void PaySalary(string inJmbg);
        int GetCashRegisterValue();
        string GetProgramInstructor(string inProgramName);
        int GetNumberOfMembersOnAProgram(string inProgramName);
        List<string> GetMembersPrograms(string inJmbg);
        Dictionary<string, Member> GetAllMembers();
        Dictionary<string, Program> GetAllPrograms();
        Dictionary<string, Instructor> GetAllInstructors();
        bool MemberExists(string inJmbg);
        bool ProgramExists(string inName);
        bool InstructorExists(string inJmbg);
        int GetInstructorsSalary(string inJmbg);
        int GetMembership(string inJmbg);
        int GetNumberOfMembers();
        int GetNumberOfInstructors();
        int GetNumberOfPrograms();
    }
}