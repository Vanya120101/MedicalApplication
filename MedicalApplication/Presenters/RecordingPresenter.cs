using MedicalApplication.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Presenters
{
    class RecordingPresenter : PresenterBase<IRecordingForm>, IPresenterBase
    {
        protected override IRecordingForm Form { get; set; }

        public RecordingPresenter(IBaseForm form) : base(form)
        {
            Initialize();

        }
        protected override void Initialize()
        {
            Form.ClickOnChangeRecording += Form_ClickOnChangeRecording;
            Form.ClickOnCreateRecording += Form_ClickOnCreateRecording;
            Form.ClickOnOtherDate += Form_ClickOnOtherDate;
            Form.ClickOnSaveRecordingChanged += Form_ClickOnSaveRecordingChanged;
        }

        private void Form_ClickOnSaveRecordingChanged()
        {
        }

        private void Form_ClickOnOtherDate()
        {
        }

        private void Form_ClickOnCreateRecording()
        {
        }

        private void Form_ClickOnChangeRecording()
        {
        }
    }
}
