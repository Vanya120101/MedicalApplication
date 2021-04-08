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

namespace MedicalApplication.Views.Controls
{
    public partial class DoctorsListControl : UserControl
    {
        public DoctorsListControl()
        {
            InitializeComponent();
            

        }

        private void BottomPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public new void Show()
        {
            this.BringToFront();
           
        }

        private void AddDoctorButton_Click(object sender, EventArgs e)
        {
            DoctorForm addDoctorForm = new DoctorForm();
            addDoctorForm.Show(FormMode.IsCreating);
        }

        private void DoctorInformationButton_Click(object sender, EventArgs e)
        {
            DoctorForm addDoctorForm = new DoctorForm();
            addDoctorForm.Show(FormMode.IsShowing);
        }
    }
}
