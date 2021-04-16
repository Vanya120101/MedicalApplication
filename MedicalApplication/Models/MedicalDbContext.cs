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
    class MedicalDbContext : DbContext
    {
        public MedicalDbContext() : base("MedicalDbConnection")
        {

        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Recording> Recordings { get; set; }

        public static event Action UpdateDoctors;
        public static event Action UpdatePatients;
        public static event Action UpdateRecordings;

        public string CheckAndAddDoctor(string firstDoctorName, string secondDoctorName, string thirdDoctorName, string doctorSpeciality, DateTime doctorBirthdate, string doctorExperience)
        {
            if (string.IsNullOrEmpty(firstDoctorName))
            {
                return "Имя доктора не должно быть пустым";
            }
            if (string.IsNullOrEmpty(secondDoctorName))
            {
                return "Фамилия доктора не должно быть пустой";
            }
            if (string.IsNullOrEmpty(thirdDoctorName))
            {
                return "Отчество доктора не должно быть пустым";
            }
            if (string.IsNullOrEmpty(doctorSpeciality))
            {
                return "Специальность доктора не должна быть пустой";
            }
            if (doctorBirthdate > DateTime.Now || doctorBirthdate < new DateTime(1900, 01, 01))
            {
                return "Дата рождения доктора должна быть меньше сегодняшей и больше, чем 1900 года";
            }
            if (string.IsNullOrEmpty(doctorExperience))
            {
                return "Опыт доктора не должен быть пустым";
            }

            Doctor doctor = new Doctor(firstDoctorName, secondDoctorName, thirdDoctorName, doctorSpeciality, doctorBirthdate, doctorExperience);

            this.Doctors.Add(doctor);
            this.SaveChanges();
            if (UpdateDoctors != null)
            {
                UpdateDoctors.Invoke();
            }
            return null;
        }

        public string CheckAndRemoveDoctor(Doctor doctor)
        {
            if (doctor == null)
            {
                return "Доктор не выбран";
            }
            this.Doctors.Remove(doctor);
            this.SaveChanges();

            if (UpdateDoctors != null)
            {
                UpdateDoctors.Invoke();
            }
            return null;
        }
        public string CheckAndChangeDoctor(Doctor doctor)
        {
            if (string.IsNullOrEmpty(doctor.FirstDoctorName))
            {
                return "Имя доктора не должно быть пустым";
            }
            if (string.IsNullOrEmpty(doctor.SecondDoctorName))
            {
                return "Фамилия доктора не должно быть пустой";
            }
            if (string.IsNullOrEmpty(doctor.ThirdDoctorName))
            {
                return "Отчество доктора не должно быть пустым";
            }
            if (string.IsNullOrEmpty(doctor.DoctorSpeciality))
            {
                return "Специальность доктора не должна быть пустой";
            }
            if (doctor.DoctorBirthdate > DateTime.Now || doctor.DoctorBirthdate < new DateTime(1900, 01, 01))
            {
                return "Дата рождения доктора должна быть меньше сегодняшей и больше, чем 1900 года";
            }
            if (string.IsNullOrEmpty(doctor.DoctorExperience))
            {
                return "Опыт доктора не должен быть пустым";
            }

            this.Entry(doctor).State = EntityState.Modified;
            this.SaveChanges();
            
            if (UpdateDoctors != null)
            {
                UpdateDoctors.Invoke();
            }
            return null;
        }

        public string CheckAndAddPatient(string firstPatientName, string secondPatientName, string thirdPatientName, string patientSpeciality, DateTime patientBirthdate)
        {

            if (string.IsNullOrEmpty(firstPatientName))
            {
                return "Имя пациента не должно быть пустым";
            }
            if (string.IsNullOrEmpty(secondPatientName))
            {
                return "Фамилия пациента не должно быть пустой";
            }
            if (string.IsNullOrEmpty(thirdPatientName))
            {
                return "Отчество пациента не должно быть пустым";
            }
            if (string.IsNullOrEmpty(patientSpeciality))
            {
                return "Специальность пациента не должна быть пустой";
            }
            if (patientBirthdate > DateTime.Now || patientBirthdate < new DateTime(1900, 01, 01))
            {
                return "Дата рождения пациента должна быть меньше сегодняшей и больше, чем 1900 года";
            }

            Patient patient = new Patient(firstPatientName, secondPatientName, thirdPatientName, patientSpeciality, patientBirthdate);

            this.Patients.Add(patient);
            this.SaveChanges();
            if (UpdatePatients != null)
            {
                UpdatePatients.Invoke();
            }
            return null;
        }
        public string CheckAndRemovePatient(Patient patient)
        {
            if (patient == null)
            {
                return "Пациент не выбран";
            }

            this.Patients.Remove(patient);
            this.SaveChanges();

            if (UpdatePatients != null)
            {
                UpdatePatients.Invoke();
            }
            return null;
        }
        public string CheckAndChangePatient(Patient patient)
        {
            if (string.IsNullOrEmpty(patient.FirstPatientName))
            {
                return "Имя пациента не должно быть пустым";
            }
            if (string.IsNullOrEmpty(patient.SecondPatientName))
            {
                return "Фамилия пациента не должно быть пустой";
            }
            if (string.IsNullOrEmpty(patient.ThirdPatientName))
            {
                return "Отчество пациента не должно быть пустым";
            }
            if (string.IsNullOrEmpty(patient.PatientSpeciality))
            {
                return "Специальность пациента не должна быть пустой";
            }
            if (patient.PatientBirthdate > DateTime.Now || patient.PatientBirthdate < new DateTime(1900, 01, 01))
            {
                return "Дата рождения пациента должна быть меньше сегодняшей и больше, чем 1900 года";
            }


            

            this.Entry(patient).State = EntityState.Modified;
            this.SaveChanges();
            if (UpdatePatients != null)
            {
                UpdatePatients.Invoke();
            }
            return null;
        }

        public string CheckAndAddRecording(Doctor doctor, Patient patient, DateTime meetingTime, string recordingStatus, string recordingCause)
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

            Recording recording = new Recording(doctor, patient, meetingTime, recordingStatus, recordingCause);
            this.Recordings.Add(recording);
            this.SaveChanges();
            if (UpdateRecordings != null)
            {
                UpdateRecordings.Invoke();
            }

            return null;
        }
        public string CheckAndRemoveRecording(Recording recording)
        {
            if (recording == null)
            {
                return "Приём не выбран";
            }
            this.Recordings.Remove(recording);
            this.SaveChanges();


            if (UpdateRecordings != null)
            {
                UpdateRecordings.Invoke();
            }
            return null;
        }

        public string CheckAndChangeRecording(Recording recording)
        {
            if (recording.Doctor == null)
            {
                return "Доктор не должен быть пустым";
            }
            if (recording.Patient == null)
            {
                return "Пациент не должен быть пустым";
            }
            if (recording.MeetingTime < new DateTime(1900, 01, 01))
            {
                return "Дата приема не должна быть столь далека";
            }
            if (string.IsNullOrEmpty(recording.RecordingCause))
            {
                return "Причина приема не должна быть пустой";
            }
            if (string.IsNullOrEmpty(recording.RecordingCause))
            {
                return "Статус приёма не должен быть пустым";
            }

            this.Entry(recording).State = EntityState.Modified;
            this.SaveChanges();
            if (UpdateRecordings != null)
            {
                UpdateRecordings.Invoke();
            }
            return null;
        }

        public BindingList<Doctor> GetDoctors()
        {
            this.Doctors.Load();
            return this.Doctors.Local.ToBindingList();
        }
    }
}
