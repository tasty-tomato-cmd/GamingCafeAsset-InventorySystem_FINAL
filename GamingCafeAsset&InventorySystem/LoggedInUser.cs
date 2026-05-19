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
    }
}
