using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.BO
{
    class MedicalPrescription
    {
        #region Private variables
        private uint MedicalPrescriptionID { get; set; }
        private DateTime Date { get; set; }

        private double Surcharge { get; set; }
        #endregion
    }
}
