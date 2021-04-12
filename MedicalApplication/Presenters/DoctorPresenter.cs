using MedicalApplication.Domain_Models;
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
        public DoctorPresenter(IBaseForm form) : base(form)
        {
            Initialize();

        }

        protected override void Initialize()
        {
            Form.ClickOnChangeDoctor += Form_ClickOnChangeDoctor;
            //  Form.ClickOnCreateDoctor += Form_ClickOnCreateDoctor;
            Form.ClickOnCreateDoctor += () => { Form_ClickOnCreateDoctor(Form.DoctorFirstName, Form.DoctorSecondName, Form.DoctorThirdName, Form.DoctorBirthdate, Form.DoctorSpeciality, Form.DoctorExperience); };

            Form.ClickOnOtherDate += Form_ClickOnOtherDate;
            Form.ClickOnSaveDoctorChanged += Form_ClickOnSaveDoctorChanged;
        }

        private void Form_ClickOnCreateDoctor(string doctorFirstName, string doctorSecondName, string doctorThirdName, DateTime doctorBirthdate, string doctorSpeciality, string doctorExperience)
        {
            string errorMessage = MedicalDbContext.CheckAndAddDoctor(doctorFirstName, doctorSecondName, doctorThirdName, doctorSpeciality, doctorBirthdate, doctorExperience);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                Form.ShowErrorMessage(errorMessage);
                return;
            }
            PresenterService.Close(Presenters.DoctorForm);

        }

      
        public override void Show<T>(FormMode formMode, T currentObject)
        {
            Doctor doctor = currentObject as Doctor;
            if (doctor == null)
            {
                return;
            }

            Form.DoctorFirstName = doctor.FirstDoctorName;
            Form.DoctorSecondName = doctor.SecondDoctorName;
            Form.DoctorThirdName = doctor.ThirdDoctorName;
            Form.DoctorBirthdate = doctor.DoctorBirthdate;
            Form.DoctorSpeciality = doctor.DoctorSpeciality;
            Form.DoctorExperience = doctor.DoctorExperience;
            this.Show(formMode);
        }
        private void Form_ClickOnSaveDoctorChanged()
        {

        }

        private void Form_ClickOnOtherDate()
        {
        }

 

        private void Form_ClickOnChangeDoctor()
        {
        }

      
    }
}
