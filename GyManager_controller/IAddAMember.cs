using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GyManager_controller
{
    public interface IAddAMember 
    {
        int ShowForm();
        string GetName();
        string GetSurname();
        string GetJmbg();
        void ExceptionHandle(string text);
    }
}
