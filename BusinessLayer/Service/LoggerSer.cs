//using Microsoft.Extensions.Logging;
//using BusinessLayer.Interface;

//namespace BusinessLayer.Service
//{
//    public class LoggerSer<T> : ILoggerSer<T>
//    {
//        private readonly ILoggerSer<T> _logger;

//        public LoggerSer(ILoggerSer<T> logger)
//        {
//            _logger = logger;
//        }

//        public void LogInfo(string message)
//        {
//            _logger.LogInfo(message);
//        }

//        public void LogWarning(string message)
//        {
//            _logger.LogWarning(message);
//        }

//        public void LogError(string message, Exception? ex = null)
//        {
//            _logger.LogError(message,ex);
//        }
//    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;
using BusinessLayer.Interface;

namespace BusinessLayer.Service
{
    public class LoggerSer<T> : ILoggerSer<T>
    {
        private readonly ILogger<T> _logger;

        public LoggerSer(ILogger<T> logger)
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