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
    class RecordingsTabPrsenter : PresenterBase<ITabControl<Recording>>, IPresenterBase
    {
        protected override ITabControl<Recording> Form { get; set; }
        public RecordingsTabPrsenter(IBaseForm form) : base(form)
        {
            //MedicalDbContext.Recordings.Load();
            //MedicalDbContext.Patients.Load();
            //MedicalDbContext.Doctors.Load();

            Recordings.UpdateRecordings += MedicalDbContext_UpdateRecordings;
            Initialize();

        }

        private void MedicalDbContext_UpdateRecordings()
        {

            //MedicalDbContext.Recordings.Load();
            //MedicalDbContext.Patients.Load();
            //MedicalDbContext.Doctors.Load();
            //Form.Table = MedicalDbContext.Recordings.Local.ToBindingList();

            Form.Table = Recordings.GetRecordings();
            Form.UpdateTable();
        }

        protected override void Initialize()
        {
            Form.ClickOnAdd += Form_ClickOnAdd;
            Form.ClickOnRemove += () => { Form_ClickOnRemove(Form.CurrentObject, Form.CurrentSelectedIndex); };
            Form.ClickOnShowInformation += Form_ClickOnShowInformation;

            Form.Table = Recordings.GetRecordings();
        }

        private void Form_ClickOnShowInformation()
        {
            PresenterService.Show(Presenters.RecordingForm, FormMode.IsShowing, Form.CurrentObject);
        }

        private void Form_ClickOnRemove(Recording recording, int currentIndex)
        {
            string errorMessage = Recordings.CheckRemoveRecording(recording);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                Form.ShowErrorMessage(errorMessage);
                return;
            }

            SetSelectedIndex(currentIndex);
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
            PresenterService.Show(Presenters.RecordingForm, FormMode.IsCreating);
        }

        public void Update()
        {
            Form.Table = Recordings.GetRecordings();

        }
    }
}
