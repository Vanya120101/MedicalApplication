using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Views.Interfaces
{
    interface ITabControl<T> : IBaseForm
    {
        event Action ClickOnShowInformation;
        event Action ClickOnAdd;
        event Action ClickOnRemove;

        BindingList<T> Table { get; set; }

        T CurrentObject { get; set; }

        int CurrentSelectedIndex { get; set; }

        void UpdateTable();
    }
}
