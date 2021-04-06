using MedicalApplication.Views.Controls;
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
    public partial class MedicalForm : Form
    {
        DoctorsListControl DoctorsListControl;
        PatientsListControl PatientsListControl;
        RecordingsListControl RecordingsListControl;
        public MedicalForm()
        {
            InitializeComponent();
            DoctorsListControl = new DoctorsListControl();
            this.ContentPanel.Controls.Add(DoctorsListControl);
            DoctorsListControl.Dock = DockStyle.Fill;

            PatientsListControl = new PatientsListControl();
            this.ContentPanel.Controls.Add(PatientsListControl);
            PatientsListControl.Dock = DockStyle.Fill;

            RecordingsListControl = new RecordingsListControl();
            this.ContentPanel.Controls.Add(RecordingsListControl);
            RecordingsListControl.Dock = DockStyle.Fill;

            

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoctorsButton_Click(object sender, EventArgs e)
        {
            DoctorsListControl.Show();
        }

        private void PatientsButton_Click(object sender, EventArgs e)
        {
            PatientsListControl.Show();
        }

        private void RecordingButton_Click(object sender, EventArgs e)
        {
            RecordingsListControl.Show();
        }
    }
}
