using MedicalApplication.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Views.Interfaces
{
    interface IBaseForm
    {
        void Show();
        void Close();
        void Clear();

        void Show(FormMode mode);
        void ShowErrorMessage(string errorMessage);

    }
}
