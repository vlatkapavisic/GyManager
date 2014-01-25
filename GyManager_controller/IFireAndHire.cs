using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GyManager_controller
{
    public interface IFireAndHire
    {
        int ShowForm();
        string GetFiredJmbg();
        string GetHiredJmbg();
        string GetHiredName();
        string GetHiredSurname();
        void ExceptionHandle(string text);
    }
}
