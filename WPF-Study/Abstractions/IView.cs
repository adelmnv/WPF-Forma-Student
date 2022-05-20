using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Study.Abstractions
{
    interface IView
    {
        string Id { get; set; }
        string StName { get; set; }
        string Roll { get; set; }
        string All { get; set; }
        string TextBox { get; set; }
        string Button { get; set; }

        event EventHandler GetInformation;


    }
}
