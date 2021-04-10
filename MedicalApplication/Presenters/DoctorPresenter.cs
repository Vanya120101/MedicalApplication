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

        }

        protected override void Initialize()
        {
            Form.ClickOnChangeDoctor += Form_ClickOnChangeDoctor;
            Form.ClickOnCreateDoctor += Form_ClickOnCreateDoctor;
            Form.ClickOnOtherDate += Form_ClickOnOtherDate;
            Form.ClickOnSaveDoctorChanged += Form_ClickOnSaveDoctorChanged;
        }

        private void Form_ClickOnSaveDoctorChanged()
        {
        }

        private void Form_ClickOnOtherDate()
        {
        }

        private void Form_ClickOnCreateDoctor()
        {
        }

        private void Form_ClickOnChangeDoctor()
        {
        }
    }
}
