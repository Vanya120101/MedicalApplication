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
    static class Patients
    {
        public static event Action UpdatePatients;
        private static MedicalDbContext medicalDbContext;

        static Patients()
        {
            medicalDbContext = MyHelper.GetContext();
        }
        public static string CheckAddPatient(string firstPatientName, string secondPatientName, string thirdPatientName, string patientSpeciality, DateTime patientBirthdate)
        {
            string errorMessage = CheckPatient(firstPatientName, secondPatientName, thirdPatientName, patientSpeciality, patientBirthdate);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                return errorMessage;
            }

            Patient patient = new Patient(firstPatientName, secondPatientName, thirdPatientName, patientSpeciality, patientBirthdate);

            
                medicalDbContext.Patients.Add(patient);
                medicalDbContext.SaveChanges();
            

            if (UpdatePatients != null)
            {
                UpdatePatients.Invoke();
            }

            return null;
        }
        public static string CheckRemovePatient(Patient patient)
        {
            string errorMessage = CheckPatient(patient);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                return errorMessage;
            }
            if (patient.Recordings.Count != 0)
            {
                return "Пациент участвует в приёме, сначала удалите прием";
            }

            medicalDbContext.Entry(patient).State = EntityState.Deleted;
                medicalDbContext.SaveChanges();
            

            if (UpdatePatients != null)
            {
                UpdatePatients.Invoke();
            }
            return null;
        }

        public static string CheckChangePatient(Patient patient, string firstPatientName, string secondPatientName, string thirdPatientName, string patientSpeciality, DateTime patientBirthdate)
        {
            string errorMessage = CheckPatient(firstPatientName, secondPatientName, thirdPatientName, patientSpeciality, patientBirthdate);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                return errorMessage;
            }

            errorMessage = CheckPatient(patient);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                return errorMessage;
            }

            patient.FirstName = firstPatientName;
            patient.SecondName = secondPatientName;
            patient.ThirdName = thirdPatientName;
            patient.Speciality = patientSpeciality;
            patient.Birthdate = patientBirthdate;



            
                medicalDbContext.Entry(patient).State = EntityState.Modified;
                medicalDbContext.SaveChanges();
            

            if (UpdatePatients != null)
            {
                UpdatePatients.Invoke();
            }
            return null;
        }

        private static string CheckPatient(string firstPatientName, string secondPatientName, string thirdPatientName, string patientSpeciality, DateTime patientBirthdate)
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

            return null;

        }

        private static string CheckPatient(Patient patient)
        {
            if (patient == null)
            {
                return "Пациент не выбран";
            }
            return null;
        }

        public static BindingList<Patient> GetPatients()
        {
            BindingList<Patient> patients;
            
                medicalDbContext.Patients.Load();
                patients = medicalDbContext.Patients.Local.ToBindingList();
            

            return patients;
        }
    }
}
