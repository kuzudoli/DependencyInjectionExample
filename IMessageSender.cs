using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample2
{
    interface IMessageSender
    {
        void SendMessage(string message);
        
        static IMessageSender CreateMessageSender()
        {
            IMessageSender messageSender;

            var messageSenderType = ConfigurationManager.AppSettings;

            if (messageSenderType[1] == "SMS")
                messageSender = new SMSSender();
            else
                messageSender = new MailSender();

            return messageSender;
        }
    }
}
