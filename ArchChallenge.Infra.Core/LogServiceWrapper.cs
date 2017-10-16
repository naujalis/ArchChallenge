using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchChallenge.Infra.Core
{
    public class LogServiceWrapper
    {
        private ILogger _logger;
        public LogServiceWrapper(ILogger logger, string transactionId)
        {
            _logger = logger;
        }
        
        public void RegisterTrace(string transactionId, string message)
        {
            _logger.LogTrace(message);
        }

        public void RegisterError(string transactionId, string message, Exception e)
        {
            _logger.LogError(message, e);
        }

        public void RegisterEvent(string transactionId, string message)
        {
            _logger.LogInformation(message);
        }
    }
}