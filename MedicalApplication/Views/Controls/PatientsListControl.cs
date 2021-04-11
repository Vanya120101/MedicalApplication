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
    public partial class PatientsListControl : UserControl, ITabControl<Patient>
    {
        #region Constructs
        public PatientsListControl()
        {
            InitializeComponent();
        }
        #endregion
        #region Events

      

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            if (ClickOnAdd != null)
            {
                ClickOnAdd.Invoke();
            }
        }

        private void PatientInformationButton_Click(object sender, EventArgs e)
        {
            if (ClickOnShowInformation != null)
            {
                ClickOnShowInformation.Invoke();
            }
        }
        private void RemovePatientButton_Click(object sender, EventArgs e)
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
        public BindingList<Patient> Table { get => this.PatientsList.DataSource as BindingList<Patient>; set => this.PatientsList.DataSource = value; }

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
        #endregion


    }
}
