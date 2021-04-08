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
    public partial class MyBaseForm : UserControl
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
        public MyBaseForm()
        {
            //InitializeComponent();
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

        public virtual void DoCreatingMode() { }
       

        public virtual void DoShowingMode() { }


        public virtual void DoEditingMode() { }
  

        public virtual void SetEnabled(bool isEnabled) { }
    }
}
