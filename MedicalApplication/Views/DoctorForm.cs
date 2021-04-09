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
    public partial class DoctorForm : Form, IDoctorForm
    {
        #region Constructs

        public DoctorForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Implement IDoctorForm

        public event Action ClickOnCreateDoctor;
        public event Action ClickOnSaveDoctorChanged;
        public event Action ClickOnChangeDoctor;
        public event Action ClickOnOtherDate;

        public string DoctorFirstName { get => this.DoctorFirstNameBox.Text; set => this.DoctorFirstNameBox.Text = value; }
        public string DoctorSecondName { get => this.DoctorSecondNameBox.Text; set => this.DoctorSecondNameBox.Text = value; }
        public string DoctorThirdName { get => this.DoctorThirdNameBox.Text; set => this.DoctorThirdNameBox.Text = value; }
        public DateTime DoctorBirthdate { get => this.DoctorBirthdateBox.Value; set => this.DoctorBirthdateBox.Value = value; }
        public string DoctorSpeciality { get => this.DoctorSpecialtyBox.Text; set => this.DoctorSpecialtyBox.Text = value; }
        public string DoctorExperience { get => this.DoctorExperienceBox.Text; set => this.DoctorExperienceBox.Text = value; }


        public void Show(FormMode mode)
        {
            this.FormMode = mode;
            this.Show();
        }

        public void Clear()
        {
            this.DoctorFirstNameBox.Clear();
            this.DoctorSecondNameBox.Clear();
            this.DoctorThirdNameBox.Clear();
            this.DoctorBirthdateBox.Value = DateTime.Today;
            this.DoctorSpecialtyBox.Clear();
            this.DoctorExperienceBox.Clear();
        }

        public new void Show()
        {
            base.ShowDialog();
        }

        public new void Close()
        {
            this.Visible = false;
        }

        #endregion

        #region Code for changing mode
        FormMode formMode;



        private FormMode FormMode
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
        private void DoCreatingMode()
        {
            SetEnabled(true);
            ControlDoctorButton.Text = "Создать";
            this.TopContentPanel.Text = "Добавление доктора";
        }

        private void DoShowingMode()
        {
            SetEnabled(false);
            ControlDoctorButton.Text = "Изменить";
            this.TopContentPanel.Text = "Информация о докторе";

        }

        private void DoEditingMode()
        {
            SetEnabled(true);
            ControlDoctorButton.Text = "Сохранить";
            this.TopContentPanel.Text = "Изменение информации доктора";

        }
        private void SetEnabled(bool isEnabled)
        {
            DoctorFirstNameBox.Enabled = isEnabled;
            DoctorSecondNameBox.Enabled = isEnabled;
            DoctorThirdNameBox.Enabled = isEnabled;
            DoctorBirthdateBox.Enabled = isEnabled;
            DoctorSpecialtyBox.Enabled = isEnabled;
            DoctorExperienceBox.Enabled = isEnabled;
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
        private void ControlDoctorButton_Click(object sender, EventArgs e)
        {
            switch (FormMode)
            {
                case FormMode.IsCreating:
                    if (ClickOnCreateDoctor != null)
                    {
                        ClickOnCreateDoctor.Invoke();
                    }
                    break;
                case FormMode.IsEditing:
                    if (ClickOnSaveDoctorChanged != null)
                    {
                        ClickOnSaveDoctorChanged.Invoke();
                    }
                    break;
                case FormMode.IsShowing:
                    if (ClickOnChangeDoctor != null)
                    {
                        ClickOnChangeDoctor.Invoke();
                    }
                    break;
                default:
                    break;
            }
        }

        #endregion

        
    }
}
