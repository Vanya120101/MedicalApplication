using MedicalApplication.Domain_Models;
using MedicalApplication.Models;
using MedicalApplication.Views.Controls;
using MedicalApplication.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Presenters
{
    class DoctorsTabPresenter : PresenterBase<ITabControl<Doctor>>, IPresenterBase
    {
        protected override ITabControl<Doctor> Form { get; set; }
        public DoctorsTabPresenter(IBaseForm form) : base(form)
        {
            MedicalDbContext.Doctors.Load();
            MedicalDbContext.Update += MedicalDbContext_Update;
            Initialize();
        }

        private void MedicalDbContext_Update()
        {
            MedicalDbContext.Doctors.Load();

            Form.Table = MedicalDbContext.Doctors.Local.ToBindingList();
        }

        protected override void Initialize()
        {
            Form.ClickOnAdd += Form_ClickOnAdd;
            Form.ClickOnRemove += Form_ClickOnRemove;
            Form.ClickOnShowInformation += Form_ClickOnShowInformation;

            Form.Table = MedicalDbContext.Doctors.Local.ToBindingList();
        }

        private void Form_ClickOnShowInformation()
        {
            PresenterService.Show(Presenters.DoctorForm, FormMode.IsShowing);
        }

        private void Form_ClickOnRemove()
        {
        }

        private void Form_ClickOnAdd()
        {
            PresenterService.Show(Presenters.DoctorForm, FormMode.IsCreating);

        }

    
    }
}
