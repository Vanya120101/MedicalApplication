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
    public partial class RecordingForm : Form
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


        public RecordingForm()
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
            ControlRecordingButton.Text = "Создать";
            this.TopContentPanel.Text = "Добавление записи";
        }

        public void DoShowingMode()
        {
            SetEnabled(false);
            ControlRecordingButton.Text = "Изменить";
            this.TopContentPanel.Text = "Информация о записи";

        }

        public void DoEditingMode()
        {
            SetEnabled(true);
            ControlRecordingButton.Text = "Сохранить";
            this.TopContentPanel.Text = "Изменение информации записи";

        }
        public void SetEnabled(bool isEnabled)
        {
            DoctorFullNameBox.Enabled = isEnabled;
            PatientFullNameBox.Enabled = isEnabled;
            RecordingDateBox.Enabled = isEnabled;
            RecordingStatusBox.Enabled = isEnabled;
            RecordingCauseBox.Enabled = isEnabled;
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
