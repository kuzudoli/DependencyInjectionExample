using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample2
{
    class Processor
    {
        ILogger logger;
        IMessageSender messageSender;

        public Processor(ILogger _logger, IMessageSender _messageSender)
        {
            logger = _logger;
            messageSender = _messageSender;
        }

        public void Process()
        {
            //DBLogger logger = new DBLogger();
            //logger.WriteLog("Log Text");

            //MailSender mailSender = new MailSender();
            //mailSender.SendMessage("Message Text");

            //FileLogger logger = new FileLogger();
            //logger.WriteLog("Log Text");

            //SMSSender smsSender = new SMSSender();
            //smsSender.SendMessage("Message Text");

            logger.WriteLog("Log Text");
            messageSender.SendMessage("Message Text");
        }

        
    }
}
