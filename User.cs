using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parovic.Akuserstvo
{
    public class User
    {
        public int UserID;
        public string UserName;
        public bool Admin;
        public bool Logged;

        public bool CanEdit(int owner)
        {
            return (Admin || UserID == owner);
        }
    }
}
