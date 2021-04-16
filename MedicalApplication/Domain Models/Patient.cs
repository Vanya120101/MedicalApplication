using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Domain_Models
{
    public class Patient
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }

        public string Speciality { get; set; }
        public DateTime Birthdate { get; set; }

        public virtual ICollection<Recording> Recordings { get; set; }

        public Patient(string firstPatientName, string secondPatientName, string thirdPatientName, string patientSpeciality, DateTime patientBirthdate)
        {
            FirstName = firstPatientName;
            SecondName = secondPatientName;
            ThirdName = thirdPatientName;
            Speciality = patientSpeciality;
            Birthdate = patientBirthdate;

            Recordings = new List<Recording>();
        }

        public Patient()
        {
            Recordings = new List<Recording>();

        }

        public override string ToString()
        {
            return SecondName + " " + FirstName + " " + ThirdName;
        }

    }
}
