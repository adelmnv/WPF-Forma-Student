using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Study.Abstractions
{
    interface IModel
    {
        Person FindIn(string message, string b);
        void ShowIn(string message);
        void ReadFile();
        string ListSize();
        //string Operation();
    }
}
