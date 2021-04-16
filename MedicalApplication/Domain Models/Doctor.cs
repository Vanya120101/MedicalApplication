using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Domain_Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string Speciality { get; set; }
        public DateTime Birthdate { get; set; }
        public string Experience { get; set; }

        public virtual ICollection<Recording> Recordings { get; set; }

        public Doctor()
        { 
            Recordings = new List<Recording>();
        }
        public Doctor(string firstDoctorName, string secondDoctorName, string thirdDoctorName, string doctorSpeciality, DateTime doctorBirthdate, string doctorExperience)
        {
            FirstName = firstDoctorName;
            SecondName = secondDoctorName;
            ThirdName = thirdDoctorName;
            Speciality = doctorSpeciality;
            Birthdate = doctorBirthdate;
            Experience = doctorExperience;
            Recordings = new List<Recording>();
        }

        public override string ToString()
        {
            return SecondName + " " + FirstName + " " + ThirdName;
        }


    }
}
