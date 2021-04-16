using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApplication.Models
{
    static class MyHelper
    {
        static MedicalDbContext MedicalDbContext;
        static MyHelper()
        {
            MedicalDbContext = new MedicalDbContext();
        }

        public static MedicalDbContext GetContext()
        {
            return MedicalDbContext;
        }
    }
}
