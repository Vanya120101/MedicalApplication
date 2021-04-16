using MedicalApplication.Domain_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Models
{
    static class Recordings
    {
        public static event Action UpdateRecordings;

        public static string ChecAddRecording(Doctor doctor, Patient patient, DateTime meetingTime, string recordingStatus, string recordingCause)
        {
            string errorMessage = CheckRecording(doctor, patient, meetingTime, recordingStatus, recordingCause);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                return errorMessage;
            }

            Recording recording = new Recording(doctor, patient, meetingTime, recordingStatus, recordingCause);
            using (MedicalDbContext medicalDbContext = new MedicalDbContext())
            {
                medicalDbContext.Doctors.Attach(doctor);
                medicalDbContext.Patients.Attach(patient);
                medicalDbContext.Recordings.Add(recording);
                medicalDbContext.SaveChanges();
            }

            if (UpdateRecordings != null)
            {
                UpdateRecordings.Invoke();
            }

            return null;
        }
        public static string CheckRemoveRecording(Recording recording)
        {
            string errorMessage = CheckRecording(recording);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                return errorMessage;
            }

            using (MedicalDbContext medicalDbContext = new MedicalDbContext())
            {

                medicalDbContext.Doctors.Attach(recording.Doctor);
                medicalDbContext.Patients.Attach(recording.Patient);
                medicalDbContext.Entry(recording).State = EntityState.Deleted;
                medicalDbContext.SaveChanges();
            }

            if (UpdateRecordings != null)
            {
                UpdateRecordings.Invoke();
            }

            return null;
        }
        public static string CheckChangeRecording(Recording recording, Doctor doctor, Patient patient, DateTime meetingTime, string recordingStatus, string recordingCause)
        {

            string errorMessage = CheckRecording(doctor, patient, meetingTime, recordingStatus, recordingCause);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                return errorMessage;
            }
            errorMessage = CheckRecording(recording);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                return errorMessage;
            }

            recording.Doctor = doctor;
            recording.Patient = patient;
            recording.MeetingTime = meetingTime;
            recording.Status = recordingStatus;
            recording.Cause = recordingCause;

            using (MedicalDbContext medicalDbContext = new MedicalDbContext())
            {

                medicalDbContext.Doctors.Attach(doctor);
                medicalDbContext.Patients.Attach(patient);
                medicalDbContext.Entry(recording).State = EntityState.Modified;
                medicalDbContext.SaveChanges();
            }

           
            if (UpdateRecordings != null)
            {
                UpdateRecordings.Invoke();
            }
            return null;
        }
        private static string CheckRecording(Doctor doctor, Patient patient, DateTime meetingTime, string recordingStatus, string recordingCause)
        {
            if (doctor == null)
            {
                return "Доктор не должен быть пустым";
            }
            if (patient == null)
            {
                return "Пациент не должен быть пустым";
            }
            if (meetingTime < new DateTime(1900, 01, 01))
            {
                return "Дата приема не должна быть столь далека";
            }
            if (string.IsNullOrEmpty(recordingCause))
            {
                return "Причина приема не должна быть пустой";
            }
            if (string.IsNullOrEmpty(recordingStatus))
            {
                return "Статус приёма не должен быть пустым";
            }

            return null;

        }
        private static string CheckRecording(Recording recording)
        {

            if (recording == null)
            {
                return "Приём не выбран";
            }

            return null;
        }

        public static BindingList<Recording> GetRecordings()
        {
            BindingList<Recording> recordings;
            //using (MedicalDbContext medicalDbContext = new MedicalDbContext())
            //{
            //    medicalDbContext.Doctors.Load();
            //    medicalDbContext.Patients.Load();
            //    medicalDbContext.Recordings.Load();
            //    recordings = medicalDbContext.Recordings.Local.ToBindingList();
            //}
            MedicalDbContext medicalDbContext = new MedicalDbContext();
            medicalDbContext.Doctors.Load();
            medicalDbContext.Patients.Load();
            medicalDbContext.Recordings.Load();
            recordings = medicalDbContext.Recordings.Local.ToBindingList();
            return recordings;
        }

        public static Recording GetRecording(int id)
        {
            Recording recording = null; 
            using (MedicalDbContext medicalDbContext = new MedicalDbContext())
            {
                medicalDbContext.Doctors.Load();
                medicalDbContext.Patients.Load();
                medicalDbContext.Recordings.Load();
                BindingList<Recording> recordings = medicalDbContext.Recordings.Local.ToBindingList();

                foreach (Recording ForeachRecording in recordings)
                {
                    if (ForeachRecording.Id == id)
                    {
                        recording = ForeachRecording;
                    }
                }
            }

            return recording;

        }


    }
}
