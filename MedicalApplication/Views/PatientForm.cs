using MedicalApplication.Models;
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
    public partial class PatientForm : Form
    {
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

        internal void Show(object modeform)
        {
            throw new NotImplementedException();
        }

        public PatientForm()
        {
            InitializeComponent();
        }


        public void Show(FormMode mode)
        {
            this.FormMode = mode;
            this.Show();
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
        public void SetEnabled(bool isEnabled)
        {
            PatientFirstNameBox.Enabled = isEnabled;
            PatientSecondNameBox.Enabled = isEnabled;
            PatientThirdNameBox.Enabled = isEnabled;
            PatientBirthdateBox.Enabled = isEnabled;
            PatientSpecialtyBox.Enabled = isEnabled;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
