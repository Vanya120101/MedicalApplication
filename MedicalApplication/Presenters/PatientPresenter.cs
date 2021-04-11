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
        public PatientPresenter(IBaseForm form) : base(form)
        {
            Initialize();

        }
        protected override void Initialize()
        {
            Form.ClickOnChangePatient += Form_ClickOnChangePatient;
            Form.ClickOnCreatePatient += Form_ClickOnCreatePatient;
            Form.ClickOnOtherDate += Form_ClickOnOtherDate;
            Form.ClickOnSavePatientChanged += Form_ClickOnSavePatientChanged;
        }

        private void Form_ClickOnSavePatientChanged()
        {
        }

        private void Form_ClickOnOtherDate()
        {
        }

        private void Form_ClickOnCreatePatient()
        {
        }

        private void Form_ClickOnChangePatient()
        {
        }
    }
}
