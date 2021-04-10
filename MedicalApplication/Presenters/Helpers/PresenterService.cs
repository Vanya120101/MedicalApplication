using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Presenters
{
    static class PresenterService
    {
        private readonly static Dictionary<Presenters, IPresenterBase> Presenters;

        static PresenterService()
        {
            Presenters = new Dictionary<Presenters, IPresenterBase>();
        }
        public static void AddPresenter(Presenters presenterName,IPresenterBase presenter)
        {
            Presenters.Add(presenterName, presenter);
        }
        public static void RemovePresenter(Presenters presenterName)
        {
            Presenters.Remove(presenterName);
        }
        public static void Show(Presenters presenter)
        {
            Presenters[presenter].Show();
        }
        public static void Show(Presenters presenter, FormMode formMode)
        {
            Presenters[presenter].Show(formMode);
        }
        public static void Close(Presenters presenter)
        {
            Presenters[presenter].Close();
        }

        public static IPresenterBase GetPresenter(Presenters presenter)
        {
            return Presenters[presenter];
        }
    }

    public enum FormMode
    {
        IsOnly,
        IsCreating,
        IsEditing,
        IsShowing
    }

    public enum Presenters
    {
        Medical,
        DoctorsTab,
        PatientsTab,
        RecordingsTab,
        StatisticsTab,
        QuestionForm,
        DoctorForm,
        PatientForm,
        RecordingForm

    }

    
}
