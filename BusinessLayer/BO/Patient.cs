using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.BO
{
    class Patient
    {
        #region Private variables
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Degree { get; set; }
        public DateTime BirthDate { get; set; }
        public uint InsuranceCompany { get; set; }
        public string Info { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public uint insuranceNumber { get; set; }
        public DateTime Created { get; set; }
        public string Language { get; set; }
        public string Email { get; set; }

        public string TelephoneNumber { get; set; }
        public bool Archived { get; set; }
        public bool Infected { get; set; }
        #endregion

    }
}
