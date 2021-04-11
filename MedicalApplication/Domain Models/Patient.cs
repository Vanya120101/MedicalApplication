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

        public string FirstPatientName { get; set; }
        public string SecondPatientName { get; set; }
        public string ThirdPatientName { get; set; }

        public string PatientSpeciality { get; set; }
        public DateTime PatientBirthdate { get; set; }

        public Patient(string firstPatientName, string secondPatientName, string thirdPatientName, string patientSpeciality, DateTime patientBirthdate)
        {
            FirstPatientName = firstPatientName;
            SecondPatientName = secondPatientName;
            ThirdPatientName = thirdPatientName;
            PatientSpeciality = patientSpeciality;
            PatientBirthdate = patientBirthdate;
        }

        public Patient()
        {

        }

    }
}
