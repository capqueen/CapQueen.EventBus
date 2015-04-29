using Autofac;
using Autofac.Core;
using EventBusDemo.EventCore;
using EventBusDemo.User.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EventBusDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var userServer = new SRUserManager();
            userServer.CreateUser("gondar");
            //var b = new Container();
            //b.
            userServer.ChangeName(1, "xxxx");
            Console.Read();
        }
    }


    public class SRUser
    {
        public string UserId { get; set;}

        public string UserName { get; set; }
    }

    public class SRUserManager
    {
        public void CreateUser(string userName)
        { 
            //...
            var user = new SRUser
            {
                UserId = Guid.NewGuid().ToString(),
                UserName = userName,
            };

            EventBus.Publish<CreatedUserEvent>(new CreatedUserEvent(user));
        }

        public void ChangeName(int userId, string userName)
        {
            //..

            EventBus.Publish<UserNameChangedEvent>(new UserNameChangedEvent(userId, "old", userName));
        }
    }
}
