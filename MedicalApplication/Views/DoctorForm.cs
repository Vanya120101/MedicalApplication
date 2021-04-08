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

namespace MedicalApplication.Views
{
    public partial class DoctorForm : Form
    {
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

        


        public DoctorForm()
        {
            InitializeComponent();
        }

        public void Show(FormMode mode)
        {
            this.FormMode = mode;
            this.Show();
        }
        public void DoCreatingMode()
        {
            SetEnabled(true);
            ControlDoctorButton.Text = "Создать";
            this.TopContentPanel.Text = "Добавление доктора";
        }

        public void DoShowingMode()
        {
            SetEnabled(false);
            ControlDoctorButton.Text = "Изменить";
            this.TopContentPanel.Text = "Информация о докторе";

        }

        public void DoEditingMode()
        {
            SetEnabled(true);
            ControlDoctorButton.Text = "Сохранить";
            this.TopContentPanel.Text = "Изменение информации доктора";

        }
        public void SetEnabled(bool isEnabled)
        {
            DoctorFirstNameBox.Enabled = isEnabled;
            DoctorSecondNameBox.Enabled = isEnabled;
            DoctorThirdNameBox.Enabled = isEnabled;
            DoctorBirthdateBox.Enabled = isEnabled;
            DoctorSpecialtyBox.Enabled = isEnabled;
            DoctorExperienceBox.Enabled = isEnabled;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OtherDataButton_Click(object sender, EventArgs e)
        {

        }
    }
}
