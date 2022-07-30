using System;

namespace DependencyInjectionExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Processor processor = new Processor(ILogger.CreateLogger(), IMessageSender.CreateMessageSender());
            processor.Process();
        }
    }
}
