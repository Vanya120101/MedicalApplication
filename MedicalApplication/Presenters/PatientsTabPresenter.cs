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
            MedicalDbContext.Patients.Load();
            Initialize();
        }

        protected override void Initialize()
        {
            Form.ClickOnAdd += Form_ClickOnAdd;
            Form.ClickOnRemove += Form_ClickOnRemove;
            Form.ClickOnShowInformation += Form_ClickOnShowInformation;

            Form.Table = MedicalDbContext.Patients.Local.ToBindingList();
        }

        private void Form_ClickOnShowInformation()
        {
            PresenterService.Show(Presenters.PatientForm, FormMode.IsShowing);
        }

        private void Form_ClickOnRemove()
        {
        }

        private void Form_ClickOnAdd()
        {
            PresenterService.Show(Presenters.PatientForm, FormMode.IsCreating);
        }
    }
}
