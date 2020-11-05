using Microsoft.Extensions.Logging;
using System;
using System.IO;


//Log: этот метод предназначен для выполнения логгирования. Он принимает пять параметров:
//LogLevel: уровень детализации текущего сообщениz
//EventId: идентификатор события
//TState: некоторый объект состояния, который хранит сообщение
//Exception: информация об исключении formatter: функция форматирвания, которая с помощью 
//двух предыдущих параметов позволяет получить собственно сообщение для логгирования
//И в данном методе как раз и производится запись в текстовый файл.


namespace MyApi
{
    public class FileLogger : ILogger
    {
        private string filePath;
        private static object _lock = new object();
        public FileLogger(string path)
        {
            filePath = path;
        }
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            //return logLevel == LogLevel.Trace;
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (formatter != null)
            {
                lock (_lock)
                {
                    File.AppendAllText(filePath, formatter(state, exception) + Environment.NewLine);
                }
            }
        }
    }
}
