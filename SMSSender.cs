using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample2
{
    class SMSSender:IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(String.Format($"SMSSender : {message}"));
        }
    }
}
