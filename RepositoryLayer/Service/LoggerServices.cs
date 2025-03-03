//using Microsoft.Extensions.Logging;
//using RepositoryLayer.Interface;

//namespace RepositoryLayer.Service
//{
//    public class LoggerServices<T> : ILoggerService<T>
//    {
//        private readonly ILogger<T> _logger;

//        public LoggerServices(ILogger<T> logger)
//        {
//            _logger = logger;
//        }

//        public void LogInfo(string message)
//        {
//            _logger.LogInformation(message);
//        }

//        public void LogWarning(string message)
//        {
//            _logger.LogWarning(message);
//        }

//        public void LogError(string message, Exception? ex = null)
//        {
//            _logger.LogError(ex, message);
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;
using BusinessLayer.Interface;

namespace BusinessLayer.Service
{
    public class LoggerService<T> : ILoggerService<T>
    {
        private readonly ILogger<T> _logger;

        public LoggerService(ILogger<T> logger)
        {
            _logger = logger;
        }

        public void LogInfo(string message)
        {
            _logger.LogInformation(message);
        }

        public void LogWarning(string message)
        {
            _logger.LogWarning(message);
        }

        public void LogError(string message, Exception? ex = null)
        {
            _logger.LogError(ex, message);
        }
    }
}

