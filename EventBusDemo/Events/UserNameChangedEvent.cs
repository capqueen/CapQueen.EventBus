using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBusDemo
{
    public class UserNameChangedEvent : Event
    {
        public int UserId { get; private set; }

        public string OldUserName { get; private set; }

        public string NewUserName { get; private set; }

        public UserNameChangedEvent(int userId, string oldUserName, string newUserName)
        {
            UserId = userId;
            OldUserName = oldUserName;
            NewUserName = newUserName;
        }
    }
}
