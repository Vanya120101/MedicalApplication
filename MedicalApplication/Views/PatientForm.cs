using MedicalApplication.Models;
using MedicalApplication.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalApplication.Views
{
    public partial class PatientForm : Form, IPatientForm
    {
        #region Code for changing mode
        FormMode formMode;


        public FormMode FormMode
        {
            get
            {
                return this.formMode;
            }
            set
            {
                this.formMode = value;
                ChangeFormMode();
            }
        }



        private void ChangeFormMode()
        {
            if (FormMode == FormMode.IsCreating)
            {
                this.DoCreatingMode();
            }
            else if (FormMode == FormMode.IsShowing)
            {
                this.DoShowingMode();
            }
            else if (FormMode == FormMode.IsEditing)
            {
                this.DoEditingMode();
            }
        }

        public void DoCreatingMode()
        {
            SetEnabled(true);
            ControlPatientButton.Text = "Создать";
            this.TopContentPanel.Text = "Добавление пациента";
        }

        public void DoShowingMode()
        {
            SetEnabled(false);
            ControlPatientButton.Text = "Изменить";
            this.TopContentPanel.Text = "Информация о пациенте";

        }

        public void DoEditingMode()
        {
            SetEnabled(true);
            ControlPatientButton.Text = "Сохранить";
            this.TopContentPanel.Text = "Изменение информации пациента";

        }

        private void SetEnabled(bool isEnabled)
        {
            PatientFirstNameBox.Enabled = isEnabled;
            PatientSecondNameBox.Enabled = isEnabled;
            PatientThirdNameBox.Enabled = isEnabled;
            PatientBirthdateBox.Enabled = isEnabled;
            PatientSpecialtyBox.Enabled = isEnabled;
        }

        #endregion

        #region Constructs
        public PatientForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OtherDataButton_Click(object sender, EventArgs e)
        {
            if (ClickOnOtherDate != null)
            {
                ClickOnOtherDate.Invoke();
            }
        }
        private void ControlPatientButton_Click(object sender, EventArgs e)
        {
            switch (FormMode)
            {
                case FormMode.IsCreating:
                    if (ClickOnCreatePatient != null)
                    {
                        ClickOnCreatePatient.Invoke();
                    }
                    break;
                case FormMode.IsEditing:
                    if (ClickOnSavePatientChanged != null)
                    {
                        ClickOnSavePatientChanged.Invoke();
                    }
                    break;
                case FormMode.IsShowing:
                    if (ClickOnChangePatient != null)
                    {
                        ClickOnChangePatient.Invoke();
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Implement IPatientForm

        public event Action ClickOnCreatePatient;
        public event Action ClickOnSavePatientChanged;
        public event Action ClickOnChangePatient;
        public event Action ClickOnOtherDate;

        public string PatientFirstName { get => this.PatientFirstNameBox.Text; set => this.PatientFirstNameBox.Text = value; }
        public string PatientSecondName { get => this.PatientSecondNameBox.Text; set => this.PatientSecondNameBox.Text = value; }
        public string PatientThirdName { get => this.PatientThirdNameBox.Text; set => this.PatientThirdNameBox.Text = value; }
        public DateTime PatientBirthdate { get => this.PatientBirthdateBox.Value; set => this.PatientBirthdateBox.Value = value; }
        public string PatientSpeciality { get => this.PatientSpecialtyBox.Text; set => this.PatientSpecialtyBox.Text = value; }
        public void Show(FormMode mode)
        {
            this.FormMode = mode;
            this.Show();
        }
        public new void Show()
        {
            base.ShowDialog();
        }

        public new void Close()
        {
            this.Visible = false;
        }

        public void Clear()
        {
            PatientFirstNameBox.Clear();
            PatientSecondNameBox.Clear();
            PatientThirdNameBox.Clear();
            PatientBirthdateBox.Value = DateTime.Today;
            PatientSpecialtyBox.Clear();
        }







        #endregion

     
    }
}
