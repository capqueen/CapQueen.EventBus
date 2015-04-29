using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBusDemo.User.Events
{
    /// <summary>
    /// 用户创建后佣金计算
    /// </summary>
    public sealed class UserBonusEventHandler : IEventHandler<CreatedUserEvent>
    {
        public void Handle(CreatedUserEvent @event)
        {
            Console.WriteLine("user created bonus event handler, userId:" + @event.User.UserId);
            //LogHelper.Write("user created bonus event handler, userId:" + @event.User.UserID, LogHelper.LogMessageType.Debug);
        }
    }
}
