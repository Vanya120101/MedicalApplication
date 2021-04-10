using MedicalApplication.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalApplication.Presenters
{
    class MedicalPresenter : PresenterBase<IMedicalForm>, IPresenterBase
    {

        protected override IMedicalForm Form { get; set; }

        public MedicalPresenter(IBaseForm form) : base(form)
        {
            PresenterService.AddPresenter(Presenters.Medical, this);
        }

        protected override void Initialize()
        {
            Form.ClickOnDoctors += MedicalForm_ClickOnDoctors;
            Form.ClickOnPatients += MedicalForm_ClickOnPatients;
            Form.ClickOnRecordings += MedicalForm_ClickOnRecordings;
            Form.ClickOnStatistics += MedicalForm_ClickOnStatistics;
            Form.ClickOnQuestion += MedicalForm_ClickOnQuestion;
            Form.CloseApplication += Form_CloseApplication;
        }
        public void AddPresenter(Presenters presenterName, IPresenterBase presenter)
        {
            
            PresenterService.AddPresenter(presenterName, presenter);

        }
        private void Form_CloseApplication()
        {
            Application.Exit();
        }

        public void Start()
        {




            Form.AddTab(PresenterService.GetPresenter(Presenters.DoctorsTab).GetForm() as UserControl);
            Form.AddTab(PresenterService.GetPresenter(Presenters.PatientsTab).GetForm() as UserControl);
            Form.AddTab(PresenterService.GetPresenter(Presenters.RecordingsTab).GetForm() as UserControl);
            //Form.AddTab(PresenterService.GetPresenter(Presenters.StatisticsTab).GetForm() as UserControl);

            Application.Run(Form as Form);
        }

        private void MedicalForm_ClickOnQuestion()
        {
            PresenterService.Show(Presenters.QuestionForm);
        }

        private void MedicalForm_ClickOnStatistics()
        {
            //PresenterService.Show(Presenters.StatisticsTab);

        }

        private void MedicalForm_ClickOnRecordings()
        {
            PresenterService.Show(Presenters.RecordingsTab);

        }

        private void MedicalForm_ClickOnPatients()
        {
            PresenterService.Show(Presenters.PatientsTab);

        }

        private void MedicalForm_ClickOnDoctors()
        {
            PresenterService.Show(Presenters.DoctorsTab);

        }


    }
}
