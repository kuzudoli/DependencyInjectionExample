using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample2
{
    class FileLogger:ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(String.Format($"FileLogger : {message}"));
        }
    }
}
