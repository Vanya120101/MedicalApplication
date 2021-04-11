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
        public string FirstDoctorName { get; set; }
        public string SecondDoctorName { get; set; }
        public string ThirdDoctorName { get; set; }
        public string DoctorSpeciality { get; set; }
        public DateTime DoctorBirthdate { get; set; }
        public string DoctorExperience { get; set; }

        public Doctor() { }
        public Doctor(string firstDoctorName, string secondDoctorName, string thirdDoctorName, string doctorSpeciality, DateTime doctorBirthdate, string doctorExperience)
        {
            FirstDoctorName = firstDoctorName;
            SecondDoctorName = secondDoctorName;
            ThirdDoctorName = thirdDoctorName;
            DoctorSpeciality = doctorSpeciality;
            DoctorBirthdate = doctorBirthdate;
            DoctorExperience = doctorExperience;
        }

      
    }
}
