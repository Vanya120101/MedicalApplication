using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Domain_Models
{
    public class Recording
    {
        public int Id { get; set; }

        public Doctor Doctor { get; set; }
       
        public Patient Patient { get; set; }

     
        public DateTime MeetingTime { get; set; }
        public string Status { get; set; }
        public string Cause { get; set; }

        public Recording(Doctor doctor, Patient patient, DateTime meetingTime, string recordingStatus, string recordingCause)
        {
            Doctor = doctor;
            Patient = patient;
            MeetingTime = meetingTime;
            Status = recordingStatus;
            Cause = recordingCause;
        }

        public Recording()
        {

        }
    }
}
