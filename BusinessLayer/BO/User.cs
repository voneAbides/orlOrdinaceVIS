using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.BO
{
    class User
    {
        #region Private variables
        public uint UserID { get; set; }
        public string Degree { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort UserRole { get; set; }
        #endregion
    }
}
