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
    public partial class RecordingsListControl : UserControl, ITabControl
    {
        #region Constructs
        public RecordingsListControl()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
       

        private void AddRecordingButton_Click(object sender, EventArgs e)
        {
            if (ClickOnAdd != null)
            {
                ClickOnAdd.Invoke();
            }
        }

        private void RecordingInformationButton_Click(object sender, EventArgs e)
        {
            if (ClickOnShowInformation != null)
            {
                ClickOnShowInformation.Invoke();
            }
        }

        private void RemoveRecordButton_Click(object sender, EventArgs e)
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

        #endregion

    }
}
