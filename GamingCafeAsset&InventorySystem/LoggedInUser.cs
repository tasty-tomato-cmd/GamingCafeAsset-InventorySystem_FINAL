using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingCafeAsset_InventorySystem
{
    public class LoggedInUser
    {
        public int UserID
        {
            get;
            set;
        }

        public string Username
        {
            get;
            set;
        }

        public int UserTypeID
        {
            get;
            set;
        }

        public string UserTypeName
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string PhoneNumber
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }

        public bool IsActive
        {
            get;
            set;
        }

        public DateTime DateofBirth
        {
            get;
            set;
        }
    }
}
