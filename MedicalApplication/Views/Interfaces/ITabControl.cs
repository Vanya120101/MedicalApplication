using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Views.Interfaces
{
    interface ITabControl : IBaseForm
    {
        event Action ClickOnShowInformation;
        event Action ClickOnAdd;
        event Action ClickOnRemove;
    }
}
