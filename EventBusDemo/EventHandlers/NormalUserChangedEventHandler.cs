using EventBusDemo.User.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBusDemo.EventHandlers
{
    class NormalUserChangedEventHandler : IEventHandler<CreatedUserEvent>
    {
        public void Handle(CreatedUserEvent @event)
        {
            throw new Exception("发送短信失败!");
        }
    }
}
