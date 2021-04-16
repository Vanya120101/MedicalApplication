using MedicalApplication.Domain_Models;
using MedicalApplication.Models;
using MedicalApplication.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Presenters
{
    class PatientsTabPresenter : PresenterBase<ITabControl<Patient>>, IPresenterBase
    {
        protected override ITabControl<Patient> Form { get; set; }
        public PatientsTabPresenter(IBaseForm form) : base(form)
        {
          //  MedicalDbContext.Patients.Load();
            Patients.UpdatePatients += MedicalDbContext_UpdatePatients;
            Initialize();
        }

        private void MedicalDbContext_UpdatePatients()
        {
            //MedicalDbContext.Patients.Load();
            //Form.Table = MedicalDbContext.Patients.Local.ToBindingList();
            Form.Table = Patients.GetPatients();
            Form.UpdateTable();
        }

        protected override void Initialize()
        {
            Form.ClickOnAdd += Form_ClickOnAdd;
            Form.ClickOnRemove += () => {Form_ClickOnRemove(Form.CurrentObject, Form.CurrentSelectedIndex); };
            Form.ClickOnShowInformation += Form_ClickOnShowInformation;

            Form.Table = Patients.GetPatients();
        }

        private void Form_ClickOnShowInformation()
        {
            PresenterService.Show<Patient>(Presenters.PatientForm, FormMode.IsShowing, Form.CurrentObject);
        }

        private void Form_ClickOnRemove(Patient patient, int currentIndex)
        {
            string errorMessage = Patients.CheckRemovePatient(patient);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                Form.ShowErrorMessage(errorMessage);
                return;
            }

            
        }

        private void SetSelectedIndex(int currentIndex)
        {
            if (currentIndex >= 0 && currentIndex < Form.Table.Count)
            {
                Form.CurrentSelectedIndex = currentIndex - 1;
            }
        }

        private void Form_ClickOnAdd()
        {
            PresenterService.Show(Presenters.PatientForm, FormMode.IsCreating);
        }
    }
}
