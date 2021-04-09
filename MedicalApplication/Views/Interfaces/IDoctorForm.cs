using MedicalApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Views.Interfaces
{
    interface IDoctorForm
    {
        string DoctorFirstName { get; set; }
        string DoctorSecondName { get; set; }
        string DoctorThirdName { get; set; }
        DateTime DoctorBirthdate { get; set; }
        string DoctorSpeciality { get; set; }
        string DoctorExperience { get; set; }

        event Action ClickOnCreateDoctor;
        event Action ClickOnSaveDoctorChanged ;
        event Action ClickOnChangeDoctor;
        event Action ClickOnOtherDate;

        void Show(FormMode mode);



    }
}
