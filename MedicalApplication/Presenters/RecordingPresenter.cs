using MedicalApplication.Domain_Models;
using MedicalApplication.Models;
using MedicalApplication.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Presenters
{
    class RecordingPresenter : PresenterBase<IRecordingForm>, IPresenterBase
    {
        protected override IRecordingForm Form { get; set; }
        Recording CurrentRecording { get; set; }
        public RecordingPresenter(IBaseForm form) : base(form)
        {
            Initialize();



        }
        protected override void Initialize()
        {
            Form.ClickOnChangeRecording += Form_ClickOnChangeRecording;
            Form.ClickOnCreateRecording += () => { Form_ClickOnCreateRecording(Form.Doctor, Form.Patient, Form.MeetingTime, Form.RecordingCause, Form.RecordingStatus); };
            Form.ClickOnOtherDate += Form_ClickOnOtherDate;
            Form.ClickOnSaveRecordingChanged += Form_ClickOnSaveRecordingChanged;

            MedicalDbContext.Patients.Load();
            MedicalDbContext.Doctors.Load();

            Form.PatientsList = MedicalDbContext.Patients.Local.ToBindingList();
            Form.DoctorsList = MedicalDbContext.Doctors.Local.ToBindingList();

            MedicalDbContext.UpdateDoctors += MedicalDbContext_Update;
            MedicalDbContext.UpdatePatients += MedicalDbContext_Update;
        }

        private void MedicalDbContext_Update()
        {
            Form.Clear();
            //MedicalDbContext.Patients.Load();
            //MedicalDbContext.Doctors.Load();
            //Form.PatientsList = MedicalDbContext.Patients.Local.ToBindingList();
            //Form.DoctorsList = MedicalDbContext.GetDoctors();
            Form.DoctorsList = new BindingList<Doctor>();

            foreach (Doctor doctor in MedicalDbContext.Doctors)
            {
                Form.DoctorsList.Add(doctor);
            }

            Form.PatientsList = new BindingList<Patient>();

            foreach (Patient patient in MedicalDbContext.Patients)
            {
                Form.PatientsList.Add(patient);
            }
            
            Form.RefreshTable();
        }

        private void Form_ClickOnCreateRecording(Doctor doctor, Patient patient, DateTime meetingTime, string recordingCause, string recordingStatus)
        {
            string errorMessage = MedicalDbContext.CheckAndAddRecording(doctor, patient, meetingTime, recordingStatus, recordingCause);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                Form.ShowErrorMessage(errorMessage);
                return;
            }
            PresenterService.Close(Presenters.RecordingForm);
        }

        public override void Show<T>(FormMode formMode, T currentObject)
        {
            CurrentRecording = currentObject as Recording;
            if (CurrentRecording == null)
            {
                Form.ShowErrorMessage("Что-то пошло не так");
                return;
            }

            Form.Doctor = CurrentRecording.Doctor;
            Form.Patient = CurrentRecording.Patient;
            Form.MeetingTime = CurrentRecording.MeetingTime;
            Form.RecordingCause = CurrentRecording.RecordingCause;
            Form.RecordingStatus = CurrentRecording.RecordingStatus;

            this.Show(formMode);
        }

        private void Form_ClickOnSaveRecordingChanged()
        {
            if (CurrentRecording == null)
            {
                Form.ShowErrorMessage("Что-то пошло не так");
                return;
            }

            CurrentRecording.Doctor = Form.Doctor;
            CurrentRecording.Patient = Form.Patient;
            CurrentRecording.MeetingTime = Form.MeetingTime;
            CurrentRecording.RecordingCause = Form.RecordingCause;
            CurrentRecording.RecordingStatus = Form.RecordingStatus;

            string errorMessage = MedicalDbContext.CheckAndChangeRecording(CurrentRecording);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                Form.ShowErrorMessage(errorMessage);
                return;
            }
            PresenterService.Close(Presenters.RecordingForm);
        }

        private void Form_ClickOnOtherDate()
        {
        }

        

        private void Form_ClickOnChangeRecording()
        {
        }
    }
}
