using MedicalApplication.Domain_Models;
using MedicalApplication.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Views.Interfaces
{
    interface IRecordingForm : IBaseForm
    {
        Doctor Doctor { get; set; }
        Patient Patient { get; set; }
        BindingList<Doctor> DoctorsList { get; set; }
        BindingList<Patient> PatientsList { get; set; }
        DateTime MeetingTime { get; set; }
        string RecordingStatus { get; set; }
        string RecordingCause { get; set; }

        event Action ClickOnCreateRecording;
        event Action ClickOnSaveRecordingChanged;
        event Action ClickOnChangeRecording;
        event Action ClickOnOtherDate;

        void RefreshTable();

    }
}
