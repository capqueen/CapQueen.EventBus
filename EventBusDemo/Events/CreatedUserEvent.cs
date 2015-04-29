using EventBusDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBusDemo.User.Events
{
    /// <summary>
    /// 用户创建事件，发生在用户创建成功之后，包含用户对象
    /// </summary>
    public sealed class CreatedUserEvent : Event
    {
        /// <summary>
        /// 创建的用户信息
        /// </summary>
        public SRUser User { get; private set; }
        
        public CreatedUserEvent(SRUser user)
        {
            User = user;
        }
    }
}
