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
    public partial class DoctorsListControl : UserControl, ITabControl<Doctor>
    {
        #region Constructs
        public DoctorsListControl()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
       

       

        private void AddDoctorButton_Click(object sender, EventArgs e)
        {
            if (ClickOnAdd != null)
            {
                ClickOnAdd.Invoke();
            }
        }

        private void DoctorInformationButton_Click(object sender, EventArgs e)
        {
            if (ClickOnShowInformation != null)
            {
                ClickOnShowInformation.Invoke();
            }
        }
        private void RemoveDoctorButton_Click(object sender, EventArgs e)
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
        public BindingList<Doctor> Table { get => this.DoctorsList.DataSource as BindingList<Doctor>; set => this.DoctorsList.DataSource=value; }

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
