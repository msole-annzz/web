using System;
using Microsoft.Extensions.Logging;


namespace MyApi
//класс добавляет к объекту ILoggerFactory метод расширения AddFile, 
//который будет добавлять наш провайдер логгирования.
{
    public static class FileLoggerExtensions
    {
        public static ILoggerFactory AddFile(this ILoggerFactory factory,
                                        string filePath)
        {
            factory.AddProvider(new FileLoggerProvider(filePath));
            return factory;
        }
    }
}
