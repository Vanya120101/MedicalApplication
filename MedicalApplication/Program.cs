using MedicalApplication.Presenters;
using MedicalApplication.Views;

using MedicalApplication.Views.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalApplication
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MedicalPresenter medicalPresenter = new MedicalPresenter(new MedicalForm());
            medicalPresenter.AddPresenter(Presenters.Presenters.DoctorsTab, new DoctorsTabPresenter(new DoctorsListControl()));
            medicalPresenter.AddPresenter(Presenters.Presenters.PatientsTab, new PatientsTabPresenter(new PatientsListControl()));
            medicalPresenter.AddPresenter(Presenters.Presenters.RecordingsTab, new RecordingsTabPrsenter(new RecordingsListControl()));
            medicalPresenter.AddPresenter(Presenters.Presenters.DoctorForm, new DoctorPresenter(new DoctorForm()));
            medicalPresenter.AddPresenter(Presenters.Presenters.PatientForm, new PatientPresenter(new PatientForm()));
            medicalPresenter.AddPresenter(Presenters.Presenters.RecordingForm, new RecordingPresenter(new RecordingForm()));
            medicalPresenter.AddPresenter(Presenters.Presenters.QuestionForm, new QuestionPresenter(new QuestionForm()));


            medicalPresenter.Start();
            //Application.Run(new MedicalForm());
        }
    }
}
