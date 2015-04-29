using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBusDemo
{
    public class NameChangedLogEventHandler : IEventHandler<UserNameChangedEvent>
    {

        public void Handle(UserNameChangedEvent @event)
        {
            Console.WriteLine("user Name changed olduserName:{0},newUserName:{1},userId:{2}", @event.OldUserName, @event.NewUserName, @event.UserId);
        }
    }
}
