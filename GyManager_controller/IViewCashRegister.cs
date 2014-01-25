using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GyManager_observer;

namespace GyManager_controller
{
    public interface IViewCashRegister : IObserver
    {
        void ShowForm();
        void DisplayData(string value);
    }
}
