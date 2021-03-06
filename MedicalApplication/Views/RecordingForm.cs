using MedicalApplication.Domain_Models;
using MedicalApplication.Presenters;
using MedicalApplication.Views.Interfaces;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MedicalApplication.Views
{
    public partial class RecordingForm : Form, IRecordingForm
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

        private void DoCreatingMode()
        {
            SetEnabled(true);
            ControlRecordingButton.Text = "Создать";
            this.TopContentPanel.Text = "Добавление записи";
        }

        private void DoShowingMode()
        {
            SetEnabled(false);
            ControlRecordingButton.Text = "Изменить";
            this.TopContentPanel.Text = "Информация о записи";

        }

        private void DoEditingMode()
        {
            SetEnabled(true);
            ControlRecordingButton.Text = "Сохранить";
            this.TopContentPanel.Text = "Изменение информации записи";

        }
        private void SetEnabled(bool isEnabled)
        {
            DoctorBox.Enabled = isEnabled;
            PatientBox.Enabled = isEnabled;
            RecordingDateBox.Enabled = isEnabled;
            RecordingStatusBox.Enabled = isEnabled;
            RecordingCauseBox.Enabled = isEnabled;

        }

        #endregion

        #region Constructs
        public RecordingForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events



        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ControlRecordingButton_Click(object sender, EventArgs e)
        {
            switch (FormMode)
            {
                case FormMode.IsCreating:
                    if (ClickOnCreateRecording != null)
                    {
                        ClickOnCreateRecording.Invoke();
                    }
                    break;
                case FormMode.IsEditing:
                    if (ClickOnSaveRecordingChanged != null)
                    {
                        ClickOnSaveRecordingChanged.Invoke();
                    }
                    break;
                case FormMode.IsShowing:
                    if (ClickOnChangeRecording != null)
                    {
                        FormMode = FormMode.IsEditing;
                        ClickOnChangeRecording.Invoke();
                    }
                    break;
                default:
                    break;
            }
        }



        private void OtherDataButton_Click(object sender, EventArgs e)
        {
            if (ClickOnOtherDate != null)
            {
                ClickOnOtherDate.Invoke();
            }
        }

        private Point moveStart;
        private void TopMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
                this.Location = new Point(this.Location.X + deltaPos.X, this.Location.Y + deltaPos.Y);
            }
        }

        private void TopMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                moveStart = new Point(e.X, e.Y);

            }
        }
        #endregion




        #region Implement IRecordingForm
        public event Action ClickOnCreateRecording;
        public event Action ClickOnSaveRecordingChanged;
        public event Action ClickOnChangeRecording;
        public event Action ClickOnOtherDate;

        public Doctor Doctor { get => this.DoctorBox.SelectedItem as Doctor; set => this.DoctorBox.SelectedItem = value; }
        public Patient Patient { get => this.PatientBox.SelectedItem as Patient; set => this.PatientBox.SelectedItem = value; }
        public BindingList<Doctor> DoctorsList
        {
            get
            {
                return this.DoctorBox.DataSource as BindingList<Doctor>;
            }
            set
            {

                this.DoctorBox.DataSource = value as BindingList<Doctor>;
              
            }
        }

        public BindingList<Patient> PatientsList
        {
            get
            {
                return this.PatientBox.DataSource as BindingList<Patient>;
            }
            set
            {
                this.PatientBox.DataSource = value as BindingList<Patient>;
            }
        }
        public DateTime MeetingTime { get => this.RecordingDateBox.Value; set => this.RecordingDateBox.Value = value; }
        public string RecordingStatus { get => this.RecordingStatusBox.Text; set => this.RecordingStatusBox.Text = value; }
        public string RecordingCause { get => this.RecordingCauseBox.Text; set => this.RecordingCauseBox.Text = value; }

        public new void Show()
        {

            base.ShowDialog();
        }

        public void Show(FormMode mode)
        {
            this.FormMode = mode;
            this.Show();
        }

        public new void Close()
        {
            //  this.Clear();
            //  this.Visible = false;

            base.Close();
        }

        public void Clear()
        {
            DoctorBox.DataSource = null;
            DoctorBox.Items.Clear();

            PatientBox.DataSource = null;
            PatientBox.Items.Clear();

            RecordingDateBox.Value = DateTime.Today;
            RecordingStatusBox.Clear();
            RecordingCauseBox.Clear();
        }
        public void RefreshTable()
        {
            DoctorBox.Refresh();
            PatientBox.Refresh();
        }
        public void ShowErrorMessage(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }
        #endregion
    }
}
