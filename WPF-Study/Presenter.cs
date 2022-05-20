using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Study
{
    class Presenter
    {
        private Abstractions.IModel model;
        private Abstractions.IView view;


        public Presenter(Abstractions.IModel model, Abstractions.IView view)
        {
            this.model = model;
            this.view = view;

            this.view.GetInformation += Find;
        }
        void Find(object sender, EventArgs e)
        {
            Person p = model.FindIn(view.TextBox, view.Button);
            if (p != null)
            {
                view.Id = p.Id;
                view.StName = p.FullName;
                view.Roll = p.Roll;
                view.TextBox = p.Id;
                view.All = p.Id + " of " + model.ListSize();
            }
        }
        void Save(object sender, EventArgs e)
        {
            model.ReadFile();
        }
        //void Result(object sender, EventArgs e)
        //{

        //    view.ClearText();
        //    view.GetRes(model.Operation());
        //}
        //void Show(object sender, EventArgs e)
        //{
        //    model.ShowIn(view.TextBox);
        //}
    }
}
