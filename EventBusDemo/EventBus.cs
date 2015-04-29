using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autofac;
using Autofac.Core;
using System.Reflection;

namespace EventBusDemo.EventCore
{
    /// <summary>
    /// 事件消息处理器, 负责处理事件的发布和订阅，及事件的具体调用和保障机制
    /// </summary>
    public class EventBus
    {
        private static readonly IContainer _container;

        static EventBus()
        {
            //通过AutoFac 解析所有的EventHandler
            var builder = new ContainerBuilder();
            var managerAssembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(managerAssembly)
                .Where(t => t.Name.EndsWith("EventHandler"))
                .AsImplementedInterfaces();

            _container = builder.Build();            
        }


        /// <summary>
        /// 发布一个指定事件
        /// </summary>
        /// <typeparam name="T">事件声明类</typeparam>
        /// <param name="event">事件实例</param>
        public static void Publish<T>(T @event) where T : Event
        {
            Task.Run(() => {
                try
                {
                    var handlers = _container.Resolve<IEnumerable<IEventHandler<T>>>();
                    foreach (var handle in handlers)
                    {
                        try
                        {
                            handle.Handle(@event);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(handle.GetType().Name + "执行失败," + e.Message);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(typeof(T).Name + "事件执行失败");
                }
            });
            
        }        
    }
}
