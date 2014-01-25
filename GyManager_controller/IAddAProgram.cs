using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GyManager_controller
{
    public interface IAddAProgram
    {
        int ShowForm();
        string GetProgramName();
        string GetPrice();
        string GetPlaces();
        string GetInstructorsName();
        string GetInstructorsSurname();
        string GetInstructorsJmbg();
        string GetSalary();
        void ExceptionHandle(string text);
    }
}
