using MedicalApplication.Domain_Models;
using MedicalApplication.Models;
using MedicalApplication.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Presenters
{
    class RecordingsTabPrsenter : PresenterBase<ITabControl<Recording>>, IPresenterBase
    {
        protected override ITabControl<Recording> Form { get; set; }
        public RecordingsTabPrsenter(IBaseForm form) : base(form)
        {
            MedicalDbContext.Recordings.Load();
            Initialize();

        }

        protected override void Initialize()
        {
            Form.ClickOnAdd += Form_ClickOnAdd;
            Form.ClickOnRemove += Form_ClickOnRemove;
            Form.ClickOnShowInformation += Form_ClickOnShowInformation;

            Form.Table = MedicalDbContext.Recordings.Local.ToBindingList();
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

        public void Update()
        {
            Form.Table = MedicalDbContext.Recordings.Local.ToBindingList();

        }
    }
}
