using MedicalApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Views.Interfaces
{
    interface IPatientForm
    {
        string PatientFirstName { get; set; }
        string PatientSecondName { get; set; }
        string PatientThirdName { get; set; }
        DateTime PatientBirthdate { get; set; }
        string PatientSpeciality { get; set; }

        event Action ClickOnCreatePatient;
        event Action ClickOnSavePatientChanged;
        event Action ClickOnChangePatient;
        event Action ClickOnOtherDate;

        void Show(FormMode mode);

    }
}
