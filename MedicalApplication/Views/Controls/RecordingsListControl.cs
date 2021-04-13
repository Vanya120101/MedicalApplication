using MedicalApplication.Domain_Models;
using MedicalApplication.Presenters;
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

namespace MedicalApplication.Views.Controls
{
    public partial class RecordingsListControl : UserControl, ITabControl<Recording>
    {
        #region Constructs
        public RecordingsListControl()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
       

        private void AddRecordingButton_Click(object sender, EventArgs e)
        {
            if (ClickOnAdd != null)
            {
                ClickOnAdd.Invoke();
            }
        }

        private void RecordingInformationButton_Click(object sender, EventArgs e)
        {
            if (ClickOnShowInformation != null)
            {
                ClickOnShowInformation.Invoke();
            }
        }

        private void RemoveRecordButton_Click(object sender, EventArgs e)
        {
            if (ClickOnRemove != null)
            {
                ClickOnRemove.Invoke();
            }
        }

        #endregion

        #region Implement ITabControl

        public event Action ClickOnShowInformation;
        public event Action ClickOnAdd;
        public event Action ClickOnRemove;

        public BindingList<Recording> Table { get => this.RecordingsList.DataSource as BindingList<Recording>; set => this.RecordingsList.DataSource = value; }

        public Recording CurrentObject
        {
            get
            {
                if (this.RecordingsList.CurrentRow != null)
                {
                    return this.RecordingsList.CurrentRow.DataBoundItem as Recording;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                int id = value.Id;
                int index = -1;

                foreach (DataGridViewRow row in this.RecordingsList.Rows)
                {
                    Recording doctor = row.DataBoundItem as Recording;
                    if (doctor.Id == id)
                    {
                        index = row.Index;
                        break;
                    }
                }

                this.RecordingsList[0, index].Selected = true;
            }
        }

        public int CurrentSelectedIndex
        {
            get
            {
                if (this.RecordingsList.CurrentRow != null)
                {
                    return this.RecordingsList.CurrentRow.Index;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (value >= 0 && value < RecordingsList.RowCount)
                {
                    this.RecordingsList[0, value].Selected = true;
                }
            }
        }

        public void Clear()
        {
        }

        public void Close()
        {
        }

        public new void Show()
        {
            this.BringToFront();
        }

        public void Show(FormMode mode)
        {
            this.Show();
        }
        public void ShowErrorMessage(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

        public void UpdateTable()
        {
            this.RecordingsList.Refresh();
        }
        #endregion

    }
}
