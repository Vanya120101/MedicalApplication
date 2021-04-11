using MedicalApplication.Domain_Models;
using System;
using System.Collections.Generic;
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

        public static event Action Update;

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
            if (Update != null)
            {
                Update.Invoke();
            }
            return null;
        }
    }
}
