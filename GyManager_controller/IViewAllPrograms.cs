using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GyManager;
using GyManager_observer;

namespace GyManager_controller
{
    public interface IViewAllPrograms: IObserver
    {
        void ShowForm();
        void DisplayData(Dictionary<string, Program> programs, Dictionary<string, Instructor> instructors);
    }
}
