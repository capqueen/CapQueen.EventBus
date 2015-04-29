using EventBusDemo.User.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBusDemo.EventHandlers
{
    public class GondarUserCreatedEventHandler : IEventHandler<CreatedUserEvent>
    {
        public void Handle(CreatedUserEvent @event)
        {
            throw new Exception("Gondar出错啦！");
        }
    }
}
