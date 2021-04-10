using MedicalApplication.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Presenters
{
    class RecordingsTabPrsenter : PresenterBase<ITabControl>, IPresenterBase
    {
        protected override ITabControl Form { get; set; }
        public RecordingsTabPrsenter(IBaseForm form) : base(form)
        {

        }

        protected override void Initialize()
        {
            Form.ClickOnAdd += Form_ClickOnAdd;
            Form.ClickOnRemove += Form_ClickOnRemove;
            Form.ClickOnShowInformation += Form_ClickOnShowInformation;
        }

        private void Form_ClickOnShowInformation()
        {
            PresenterService.Show(Presenters.RecordingForm, FormMode.IsShowing);
        }

        private void Form_ClickOnRemove()
        {
        }

        private void Form_ClickOnAdd()
        {
            PresenterService.Show(Presenters.RecordingForm, FormMode.IsCreating);
        }
    }
}
