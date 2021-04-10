using MedicalApplication.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Presenters
{
    interface IPresenterBase
    {
        void Show();

        void Show(FormMode formMode);
        void Close();

        IBaseForm GetForm();
    }
}
