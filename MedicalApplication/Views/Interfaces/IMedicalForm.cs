using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalApplication.Views.Interfaces
{
    interface IMedicalForm : IBaseForm
    {
        event Action ClickOnQuestion;
        event Action ClickOnDoctors;
        event Action ClickOnPatients;
        event Action ClickOnRecordings;
        event Action ClickOnStatistics;
        event Action CloseApplication;

        void AddTab(UserControl userControl);
    }
}
