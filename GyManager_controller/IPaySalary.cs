using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GyManager_controller
{
    public interface IPaySalary
    {
        int ShowForm();
        string GetJmbg();
        void ExceptionHandle(string text);
    }
}
