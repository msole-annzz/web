using Microsoft.Extensions.Logging;
// класс представляет провайдер логгирования. Он должен реализовать интерфейс ILoggerProvider
namespace MyApi
{
    public class FileLoggerProvider : ILoggerProvider
    {
        private string path;
        public FileLoggerProvider(string _path)
        {
            path = _path;
        }
        //создает и возвращает объект логгера. 
        //Для создания логгера используется путь к файлу, который передается через конструктор
        public ILogger CreateLogger(string categoryName)
        {
            return new FileLogger(path);
        }

        public void Dispose()
        {
        }
    }
}