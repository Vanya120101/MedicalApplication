using System;
using System.Collections.Generic;
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
        public string RecordingStatus { get; set; }
        public string RecordingCause { get; set; }

        public Recording(Doctor doctor, Patient patient, DateTime meetingTime, string recordingStatus, string recordingCause)
        {
            Doctor = doctor;
            Patient = patient;
            MeetingTime = meetingTime;
            RecordingStatus = recordingStatus;
            RecordingCause = recordingCause;
        }

        public Recording()
        {

        }
    }
}
