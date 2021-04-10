using MedicalApplication.Presenters;
using MedicalApplication.Views.Interfaces;
using System;
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
            DoctorFullNameBox.Enabled = isEnabled;
            PatientFullNameBox.Enabled = isEnabled;
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

        public string DoctorFullName { get => this.DoctorFullNameBox.Text; set => this.DoctorFullNameBox.Text = value; }
        public string PatientFullName { get => this.PatientFullNameBox.Text; set => this.PatientFullNameBox.Text = value; }
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
            this.Visible = false;
        }

        public void Clear()
        {
            DoctorFullNameBox.Clear();
            PatientFullNameBox.Clear();
            RecordingDateBox.Value = DateTime.Today;
            RecordingStatusBox.Clear();
            RecordingCauseBox.Clear();
        }

        #endregion
    }
}
