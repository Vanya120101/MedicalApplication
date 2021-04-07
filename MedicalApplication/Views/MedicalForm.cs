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
            SelectedIndicator.Location = DoctorsButton.Location;
            ClearSelection();
            DoctorsButton.BackColor = Color.White;



        }

        private void PatientsButton_Click(object sender, EventArgs e)
        {
            PatientsListControl.Show();
            SelectedIndicator.Location = PatientsButton.Location;
            ClearSelection();

            PatientsButton.BackColor = Color.White;


        }

        private void RecordingButton_Click(object sender, EventArgs e)
        {
            RecordingsListControl.Show();
            SelectedIndicator.Location = RecordingButton.Location;
            ClearSelection();

            RecordingButton.BackColor = Color.White;

        }

        bool isOpenedMenu = true;
        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            if (isOpenedMenu)
            {
                for (int i = 0; i <= 30; i++)
                {
                    LeftMenu.Width = 300 - (i * 10);
                }
            }
            else
            {
                for (int i = 0; i <= 10; i++)
                {
                    LeftMenu.Width = i * 30;
                }
            }
            isOpenedMenu = !isOpenedMenu;
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            SelectedIndicator.Location = StatisticsButton.Location;
            ClearSelection();

            StatisticsButton.BackColor = Color.White;

        }

        private void ClearSelection()
        {
            DoctorsButton.BackColor = Color.FromArgb(250, 250, 250);
            PatientsButton.BackColor = Color.FromArgb(250, 250, 250);
            RecordingButton.BackColor = Color.FromArgb(250, 250, 250);
            StatisticsButton.BackColor = Color.FromArgb(250, 250, 250);
        }
    }
}
