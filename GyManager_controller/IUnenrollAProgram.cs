﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GyManager_controller
{
    public interface IUnenrollAProgram
    {
        int ShowForm();
        string GetJmbg();
        string GetProgramName();
        void ExceptionHandle(string text);
    }
}
