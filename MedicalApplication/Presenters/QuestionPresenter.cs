using MedicalApplication.Views;
using MedicalApplication.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Presenters
{
    class QuestionPresenter : PresenterBase<IQuestionForm>, IPresenterBase
    {
        protected override IQuestionForm Form { get; set; }

        public QuestionPresenter(IBaseForm form) : base(form)
        {
            Initialize();

        }

        protected override void Initialize()
        {
        }
    }
}
