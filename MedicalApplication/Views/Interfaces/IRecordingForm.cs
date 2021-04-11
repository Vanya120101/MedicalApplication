using MedicalApplication.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Views.Interfaces
{
    interface IRecordingForm : IBaseForm
    {
        string DoctorFullName { get; set; }
        string PatientFullName { get; set; }
        DateTime MeetingTime { get; set; }
        string RecordingStatus { get; set; }
        string RecordingCause { get; set; }

        event Action ClickOnCreateRecording;
        event Action ClickOnSaveRecordingChanged;
        event Action ClickOnChangeRecording;
        event Action ClickOnOtherDate;

    }
}
