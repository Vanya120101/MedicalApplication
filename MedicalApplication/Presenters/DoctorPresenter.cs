using MedicalApplication.Domain_Models;
using MedicalApplication.Models;
using MedicalApplication.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Presenters
{
    class DoctorPresenter : PresenterBase<IDoctorForm>, IPresenterBase
    {
        protected override IDoctorForm Form { get; set; }
        Doctor CurrentDoctor { get; set; }
        public DoctorPresenter(IBaseForm form) : base(form)
        {
            Initialize();

        }

        protected override void Initialize()
        {
            Form.ClickOnChangeDoctor += Form_ClickOnChangeDoctor;
            Form.ClickOnCreateDoctor += () => { Form_ClickOnCreateDoctor(Form.DoctorFirstName, Form.DoctorSecondName, Form.DoctorThirdName, Form.DoctorBirthdate, Form.DoctorSpeciality, Form.DoctorExperience); };

            Form.ClickOnOtherDate += Form_ClickOnOtherDate;
            Form.ClickOnSaveDoctorChanged += Form_ClickOnSaveDoctorChanged;
        }

        private void Form_ClickOnCreateDoctor(string doctorFirstName, string doctorSecondName, string doctorThirdName, DateTime doctorBirthdate, string doctorSpeciality, string doctorExperience)
        {
            string errorMessage = Doctors.CheckAddDoctor(doctorFirstName, doctorSecondName, doctorThirdName, doctorBirthdate, doctorSpeciality,doctorExperience);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                Form.ShowErrorMessage(errorMessage);
                return;
            }
            PresenterService.Close(Presenters.DoctorForm);

        }


        public override void Show<T>(FormMode formMode, T currentObject)
        {
            CurrentDoctor = currentObject as Doctor;
            if (CurrentDoctor == null)
            {
                return;
            }

            Form.DoctorFirstName = CurrentDoctor.FirstName;
            Form.DoctorSecondName = CurrentDoctor.SecondName;
            Form.DoctorThirdName = CurrentDoctor.ThirdName;
            Form.DoctorBirthdate = CurrentDoctor.Birthdate;
            Form.DoctorSpeciality = CurrentDoctor.Speciality;
            Form.DoctorExperience = CurrentDoctor.Experience;
            this.Show(formMode);
        }
        private void Form_ClickOnSaveDoctorChanged()
        {
            if (CurrentDoctor == null)
            {
                Form.ShowErrorMessage("Что-то пошло не так");
                return;
            }

            string errorMessage = Doctors.CheckChangeDoctor(CurrentDoctor, Form.DoctorFirstName, Form.DoctorSecondName, Form.DoctorThirdName, Form.DoctorBirthdate, Form.DoctorSpeciality, Form.DoctorExperience);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                Form.ShowErrorMessage(errorMessage);
                return;
            }

            PresenterService.Close(Presenters.DoctorForm);
        }

        private void Form_ClickOnOtherDate()
        {
        }



        private void Form_ClickOnChangeDoctor()
        {
        }


    }
}
