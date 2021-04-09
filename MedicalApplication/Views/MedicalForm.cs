using MedicalApplication.Views.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MedicalApplication.Views
{
    public partial class MedicalForm : Form, IMedicalForm
    {

        #region Constructs
        public MedicalForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoctorsButton_Click(object sender, EventArgs e)
        {

        }

        private void PatientsButton_Click(object sender, EventArgs e)
        {

        }

        private void RecordingButton_Click(object sender, EventArgs e)
        {

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



        #endregion

        #region Implement IMedicalForm
        public event Action ClickOnQuestion;
        public event Action ClickOnDoctors;
        public event Action ClickOnPatients;
        public event Action ClickOnRecordings;
        public event Action ClickOnStatistics;

        public void Clear()
        {

        }

        public new void Show()
        {
            this.Show();
        }

        public new void Close()
        {
            this.Close();
        }

        #endregion
    }
}
