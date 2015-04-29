using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBusDemo
{
    public interface IEventHandler<T> where T : Event
    {
        /// <summary>
        /// 事件处理方法
        /// </summary>
        /// <param name="event">事件参数</param>
        void Handle(T @event);
    }
}
