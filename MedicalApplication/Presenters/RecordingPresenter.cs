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

            //MedicalDbContext.Patients.Load();
            //MedicalDbContext.Doctors.Load();

            Form.PatientsList = Patients.GetPatients();
            Form.DoctorsList = Doctors.GetDoctors();

            Doctors.UpdateDoctors += MedicalDbContext_Update;
            Patients.UpdatePatients += MedicalDbContext_Update;
        }

        private void MedicalDbContext_Update()
        {
            //Form.Clear();


            //MedicalDbContext.Patients.Load();
            //MedicalDbContext.Doctors.Load();
            //Form.PatientsList = MedicalDbContext.Patients.Local.ToBindingList();
            //Form.DoctorsList = MedicalDbContext.GetDoctors();



            //Form.DoctorsList = new BindingList<Doctor>();

            //foreach (Doctor doctor in MedicalDbContext.Doctors)
            //{
            //    Form.DoctorsList.Add(doctor);
            //}

            //Form.PatientsList = new BindingList<Patient>();

            //foreach (Patient patient in MedicalDbContext.Patients)
            //{
            //    Form.PatientsList.Add(patient);
            //}

            Form.PatientsList = Patients.GetPatients();
            Form.DoctorsList = Doctors.GetDoctors();

            Form.RefreshTable();
        }

        private void Form_ClickOnCreateRecording(Doctor doctor, Patient patient, DateTime meetingTime, string recordingCause, string recordingStatus)
        {
            string errorMessage = Recordings.ChecAddRecording(doctor, patient, meetingTime, recordingStatus, recordingCause);
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
            Form.RecordingCause = CurrentRecording.Cause;
            Form.RecordingStatus = CurrentRecording.Status;



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
            CurrentRecording.Cause = Form.RecordingCause;
            CurrentRecording.Status = Form.RecordingStatus;

            string errorMessage = Recordings.CheckChangeRecording(CurrentRecording, Form.Doctor, Form.Patient, Form.MeetingTime, Form.RecordingCause, Form.RecordingStatus);
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
