using MedicalApplication.Domain_Models;
using MedicalApplication.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Presenters
{
    class PatientPresenter : PresenterBase<IPatientForm>, IPresenterBase
    {
        protected override IPatientForm Form { get; set; }
        Patient CurrentPatient { get; set; }
        public PatientPresenter(IBaseForm form) : base(form)
        {
            Initialize();

        }
        protected override void Initialize()
        {
            Form.ClickOnChangePatient += Form_ClickOnChangePatient;
            Form.ClickOnCreatePatient += () => { Form_ClickOnCreatePatient(Form.PatientFirstName, Form.PatientSecondName, Form.PatientThirdName, Form.PatientBirthdate, Form.PatientSpeciality); };
            Form.ClickOnOtherDate += Form_ClickOnOtherDate;
            Form.ClickOnSavePatientChanged += Form_ClickOnSavePatientChanged;
        }

        private void Form_ClickOnCreatePatient(string patientFirstName, string patientSecondName, string patientThirdName, DateTime patientBirthdate, string patientSpeciality)
        {
            string errorMessage = MedicalDbContext.CheckAndAddPatient(patientThirdName, patientSecondName, patientThirdName, patientSpeciality, patientBirthdate);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                Form.ShowErrorMessage(errorMessage);
                return;
            }
            PresenterService.Close(Presenters.PatientForm);

        }

        public override void Show<T>(FormMode formMode, T currentObject)
        {
            CurrentPatient = currentObject as Patient;

            if (CurrentPatient == null)
            {
                Form.ShowErrorMessage("Пациент не выбран");
                return;
            }

            Form.PatientFirstName = CurrentPatient.FirstPatientName;
            Form.PatientSecondName = CurrentPatient.SecondPatientName;
            Form.PatientThirdName = CurrentPatient.ThirdPatientName;
            Form.PatientSpeciality = CurrentPatient.PatientSpeciality;
            Form.PatientBirthdate = CurrentPatient.PatientBirthdate;

            this.Show(formMode);
        }

        private void Form_ClickOnSavePatientChanged()
        {
            if (CurrentPatient == null)
            {
                Form.ShowErrorMessage("Что-то пошло не так?");
                return;
            }

            CurrentPatient.FirstPatientName = Form.PatientFirstName;
            CurrentPatient.SecondPatientName = Form.PatientSecondName;
            CurrentPatient.ThirdPatientName = Form.PatientThirdName;
            CurrentPatient.PatientSpeciality = Form.PatientSpeciality;
            CurrentPatient.PatientBirthdate = CurrentPatient.PatientBirthdate;

            string errorMessage = MedicalDbContext.CheckAndChangePatient(CurrentPatient);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                Form.ShowErrorMessage(errorMessage);
                return;
            }
            PresenterService.Close(Presenters.PatientForm);
        }

        private void Form_ClickOnOtherDate()
        {
        }

       

        private void Form_ClickOnChangePatient()
        {
        }
    }
}
