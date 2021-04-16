using MedicalApplication.Presenters;
using MedicalApplication.Views.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MedicalApplication.Views
{
    public partial class QuestionForm : Form, IQuestionForm
    {
        public QuestionForm()
        {
            InitializeComponent();
            this.InformationLabel.Text = "Данное приложение - симуляция обертки для медицинской базы данных.";
            this.InformationLabel.Text += "\n\nНа вкладке доктора можно добавлять и удалять докторов, просматривать информацию и изменять их";
            this.InformationLabel.Text += "\n\nНа вкладке пациентов можно добавлять и удалять пациентов, просматривать информацию и изменять их";
            this.InformationLabel.Text += "\n\nНа вкладке записей можно добавлять и удалять записи, просматривать информацию и изменять их";


        }

        public void Clear()
        {
        }

        public new void Show()
        {
            base.Show();
        }

        public void Show(FormMode mode)
        {
            this.Show();
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

        public void ShowErrorMessage(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

        private Point moveStart;
        private void TopMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
                this.Location = new Point(this.Location.X + deltaPos.X, this.Location.Y + deltaPos.Y);
            }
        }

        private void TopMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                moveStart = new Point(e.X, e.Y);

            }
        }

    }
}
