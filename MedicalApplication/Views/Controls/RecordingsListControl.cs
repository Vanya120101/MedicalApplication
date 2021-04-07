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
    public partial class RecordingsListControl : UserControl
    {
        public RecordingsListControl()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            this.BringToFront();
        }

        private void AddRecordingButton_Click(object sender, EventArgs e)
        {
            AddRecordingForm addRecordingForm = new AddRecordingForm();
            addRecordingForm.Show();
        }

        private void RecordingInformationButton_Click(object sender, EventArgs e)
        {
            RecordingInformationForm recordingInformationForm = new RecordingInformationForm();
            recordingInformationForm.Show();
        }
    }
}
