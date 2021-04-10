using MedicalApplication.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Presenters
{
    abstract class PresenterBase<T> where T:IBaseForm
    {
        protected abstract T Form { get; set; }
        public PresenterBase(IBaseForm form)
        {
            Form = (T)form;

            Initialize();

        }

        protected abstract void Initialize();

        public void Show()
        { 
            Form.Show();
        }
        public void Show(FormMode formMode)
        {
            Form.Show(formMode);
        }
        public void Close()
        {
            Form.Close();
        }



        public IBaseForm GetForm()
        {
            return Form;
        }
    }
}
