using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GyManager;
using GyManager = GyManager.GyManager;

namespace GyManager_controller
{
    public class Controller
    {
        public void AddAMember(IAddAMember adding)
        {
            IGyManager gymanager = Factory.CreateGyManager();
            try
            {
                string name = adding.GetName();
                string surname = adding.GetSurname();
                string jmbg = adding.GetJmbg();
                gymanager.AddMember(name, surname, jmbg);
            }
            catch (GyManagerException e)
            {
                adding.ExceptionHandle(e.msg);
            }
        }

        public void PayMembership(IPayMembership paying)
        {
            IGyManager gymanager = Factory.CreateGyManager();
            try
            {
                string jmbg = paying.GetJmbg();
                gymanager.PayMembership(jmbg);
            }
            catch (GyManagerException e)
            {
                paying.ExceptionHandle(e.msg);
            }
        }

        public void PaySalary(IPaySalary paying)
        {
            IGyManager gymanager = Factory.CreateGyManager();
            try
            {
                string jmbg = paying.GetJmbg();
                gymanager.PaySalary(jmbg);
            }
            catch (GyManagerException e)
            {
                paying.ExceptionHandle(e.msg);
            }
        }

        public void EnrollAProgram(IEnrollAProgram enrolling)
        {
            IGyManager gymanager = Factory.CreateGyManager();
            try
            {
                string jmbg = enrolling.GetJmbg();
                string pname = enrolling.GetProgramName();
                gymanager.EnrollANewProgram(pname, jmbg);
            }
            catch (GyManagerException e)
            {
                enrolling.ExceptionHandle(e.msg);
            }
        }

        public void UnenrollAProgram(IUnenrollAProgram unenrolling)
        {
            IGyManager gymanager = Factory.CreateGyManager();
            try
            {
                string jmbg = unenrolling.GetJmbg();
                string pname = unenrolling.GetProgramName();
                gymanager.UnenrollAProgram(pname, jmbg);
            }
            catch (GyManagerException e)
            {
                unenrolling.ExceptionHandle(e.msg);
            }
        }

        public void FireAndHire(IFireAndHire fhiring)
        {
            IGyManager gymanager = Factory.CreateGyManager();
            try
            {
                string fjmbg = fhiring.GetFiredJmbg();
                string hname = fhiring.GetHiredName();
                string hsurname = fhiring.GetHiredSurname();
                string hjmbg = fhiring.GetHiredJmbg();
                gymanager.FireInstructorAndHireAnother(fjmbg, hname, hsurname, hjmbg);
            }
            catch (GyManagerException e)
            {
                fhiring.ExceptionHandle(e.msg);
            }
        }

        public void AddAProgramAndAnInstructor(IAddAProgram adding)
        {
            IGyManager gymanager = Factory.CreateGyManager();
            try
            {
                string pname = adding.GetProgramName();
                string price = adding.GetPrice();
                string places = adding.GetPlaces();
                string iname = adding.GetInstructorsName();
                string isurname = adding.GetInstructorsSurname();
                string ijmbg = adding.GetInstructorsJmbg();
                string salary = adding.GetSalary();
                gymanager.AddProgramAndInstructor(pname, Convert.ToInt32(price),
                    Convert.ToInt32(places), iname, isurname, ijmbg, Convert.ToInt32(salary));
            }
            catch (GyManagerException e)
            {
                adding.ExceptionHandle(e.msg);
            }
        }

        public void ViewAllMembers(IViewAllMembers viewing)
        {
            IGyManager gymanager = Factory.CreateGyManager();
            Dictionary<string, Member> members = new Dictionary<string, Member>();
            members = gymanager.GetAllMembers();
            viewing.DisplayData(members);
            ((global::GyManager.GyManager)gymanager).AddObserver(viewing);
            viewing.ShowForm();
        }

        public void ViewCashRegister(IViewCashRegister viewing)
        {
            IGyManager gymanager = Factory.CreateGyManager();
            int value = gymanager.GetCashRegisterValue();
            viewing.DisplayData(Convert.ToString(value));
            ((global::GyManager.GyManager)gymanager).AddObserver(viewing);
            viewing.ShowForm();
        }

        public void ViewAllPrograms(IViewAllPrograms viewing)
        {
            IGyManager gymanager = Factory.CreateGyManager();
            Dictionary<string, Program> programs = new Dictionary<string, Program>();
            Dictionary<string, Instructor> instructors = new Dictionary<string, Instructor>();
            programs = gymanager.GetAllPrograms();
            instructors = gymanager.GetAllInstructors();
            viewing.DisplayData(programs, instructors);
            ((global::GyManager.GyManager)gymanager).AddObserver(viewing);
            viewing.ShowForm();
        }

        public void ViewAllInstructors(IViewAllInstructos viewing)
        {
            IGyManager gymanager = Factory.CreateGyManager();
            Dictionary<string, Instructor> instructors = new Dictionary<string, Instructor>();
            Dictionary<string, Program> programs = new Dictionary<string, Program>();
            instructors = gymanager.GetAllInstructors();
            programs = gymanager.GetAllPrograms();
            viewing.DisplayData(instructors, programs);
            ((global::GyManager.GyManager)gymanager).AddObserver(viewing);
            viewing.ShowForm();
        }

        public void UpdatedListOfMembers(IViewAllMembers viewing) 
        {
            IGyManager gymanager = Factory.CreateGyManager();
            Dictionary<string, Member> members = new Dictionary<string, Member>();
            members = gymanager.GetAllMembers();
            viewing.DisplayData(members);
        }

        public void UpdatedListOfPrograms(IViewAllPrograms viewing)
        {
            IGyManager gymanager = Factory.CreateGyManager();
            Dictionary<string, Program> programs = new Dictionary<string, Program>();
            Dictionary<string, Instructor> instructors = new Dictionary<string, Instructor>();
            programs = gymanager.GetAllPrograms();
            instructors = gymanager.GetAllInstructors();
            viewing.DisplayData(programs, instructors);
        }

        public void UpdatedListOfInstructors(IViewAllInstructos viewing)
        {
            IGyManager gymanager = Factory.CreateGyManager();
            Dictionary<string, Instructor> instructors = new Dictionary<string, Instructor>();
            Dictionary<string, Program> programs = new Dictionary<string, Program>();
            instructors = gymanager.GetAllInstructors();
            programs = gymanager.GetAllPrograms();
            viewing.DisplayData(instructors, programs);
        }

        public void UpdatedCashRegister(IViewCashRegister viewing)
        {
            IGyManager gymanager = Factory.CreateGyManager();
            int value = gymanager.GetCashRegisterValue();
            viewing.DisplayData(Convert.ToString(value));
        }

        public void DeleteAMember(IDeleteAMember deleting)
        {
            IGyManager gymanager = Factory.CreateGyManager();
            try
            {
                string jmbg = deleting.GetJmbg();
                gymanager.DeleteMember(jmbg);
            }
            catch (GyManagerException e)
            {
                deleting.ExceptionHandle(e.msg);
            }
        }
    }

    
}
