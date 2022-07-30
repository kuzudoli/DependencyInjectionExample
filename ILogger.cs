using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample2
{
    interface ILogger
    {
        void WriteLog(string message);

        static ILogger CreateLogger()
        {
            ILogger logger;
            var loggerType = ConfigurationManager.AppSettings;

            if (loggerType[0] == "DB")
                logger = new DBLogger();
            else
                logger = new FileLogger();

            return logger;
        }
    }
}
