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
    static class Doctors
    {
        public static event Action UpdateDoctors;
        private static MedicalDbContext medicalDbContext;
        
        static Doctors()
        {
            medicalDbContext = MyHelper.GetContext();
        }
        public static string CheckAddDoctor(string doctorFirstName, string doctorSecondName, string doctorThirdName, DateTime doctorBirthdate, string doctorSpeciality, string doctorExperience)
        {
            string errorMessage = CheckDoctor(doctorFirstName, doctorSecondName, doctorThirdName, doctorBirthdate, doctorSpeciality, doctorExperience);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                return errorMessage;
            }

            Doctor doctor = new Doctor(doctorFirstName, doctorSecondName, doctorThirdName, doctorSpeciality, doctorBirthdate, doctorExperience);

            
                medicalDbContext.Doctors.Add(doctor);
                medicalDbContext.SaveChanges();
            

            if (UpdateDoctors != null)
            {
                UpdateDoctors.Invoke();
            }

            return null;
        }

        public static string CheckRemoveDoctor(Doctor doctor)
        {
            string errorMessage = CheckDoctor(doctor);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                return errorMessage;
            }

            if (doctor.Recordings.Count != 0)
            {
                return "Доктор участвует в приёме, сначала удалите прием";
            }

                medicalDbContext.Entry(doctor).State = EntityState.Deleted;
                medicalDbContext.SaveChanges();
            

            if (UpdateDoctors != null)
            {
                UpdateDoctors.Invoke();
            }
            return null;
        }

        public static string CheckChangeDoctor(Doctor doctor, string doctorFirstName, string doctorSecondName, string doctorThirdName, DateTime doctorBirthdate, string doctorSpeciality, string doctorExperience)
        {
            string errorMessage = CheckDoctor(doctorFirstName, doctorSecondName, doctorThirdName, doctorBirthdate, doctorSpeciality, doctorExperience);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                return errorMessage;
            }

            errorMessage = CheckDoctor(doctor);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                return errorMessage;
            }

            doctor.FirstName = doctorFirstName;
            doctor.SecondName = doctorSecondName;
            doctor.ThirdName = doctorThirdName;
            doctor.Birthdate = doctorBirthdate;
            doctor.Speciality = doctorSpeciality;
            doctor.Experience = doctorExperience;


            
                medicalDbContext.Entry(doctor).State = EntityState.Modified;
                medicalDbContext.SaveChanges();
            

            if (UpdateDoctors != null)
            {
                UpdateDoctors.Invoke();
            }

            return null;
        }

        private static string CheckDoctor(string doctorFirstName, string doctorSecondName, string doctorThirdName, DateTime doctorBirthdate, string doctorSpeciality, string doctorExperience)
        {
            if (string.IsNullOrEmpty(doctorFirstName))
            {
                return "Имя доктора не должно быть пустым";
            }
            if (string.IsNullOrEmpty(doctorSecondName))
            {
                return "Фамилия доктора не должно быть пустой";
            }
            if (string.IsNullOrEmpty(doctorThirdName))
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

            return null;
        }

        private static string CheckDoctor(Doctor doctor)
        {
            if (doctor == null)
            {
                return "Доктор не выбран";
            }
            return null;
        }

        public static BindingList<Doctor> GetDoctors()
        {
            BindingList<Doctor> doctors;
            
                medicalDbContext.Doctors.Load();
                doctors = medicalDbContext.Doctors.Local.ToBindingList();
            

            return doctors;
        }


    }
}
