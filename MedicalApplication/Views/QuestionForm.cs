using MedicalApplication.Views.Interfaces;
using System;
using System.Windows.Forms;

namespace MedicalApplication.Views
{
    public partial class QuestionForm : Form, IBaseForm
    {
        public QuestionForm()
        {
            InitializeComponent();
        }

        public void Clear()
        {
        }

        public new void Show()
        {
            base.ShowDialog();
        }
        public new void Close()
        {
            this.Visible = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
