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
    public partial class PatientsListControl : UserControl
    {
        public PatientsListControl()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            this.BringToFront();
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatientForm = new AddPatientForm();
            addPatientForm.Show();
        }

        private void PatientInformationButton_Click(object sender, EventArgs e)
        {
            PatientInformationForm patientInformationForm = new PatientInformationForm();
            patientInformationForm.Show();
        }
    }
}
