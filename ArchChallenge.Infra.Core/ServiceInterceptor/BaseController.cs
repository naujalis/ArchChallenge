using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ArchChallenge.SharedKernel;
using Microsoft.Extensions.Logging;

namespace ArchChallenge.Infra.Core.ServiceInterceptor
{
    public class BaseController : Controller
    {
        public LogServiceWrapper Logger;
        

        public BaseController(ILogger logger)
        {
            // TODO: Preencher transactionID
            Logger = new LogServiceWrapper(logger, "");
        }

        public Request RequestInfo { get; set; }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var transactionIDHeader = Request.Headers.FirstOrDefault(a => a.Key == "TransactionID");
            string transactionID = Guid.NewGuid().ToString();

            if (String.IsNullOrEmpty(transactionIDHeader.Value))
                transactionID = Guid.NewGuid().ToString();

            RequestInfo = new Request()
            {
                StartTime = DateTime.Now,
                TransactionID = transactionID
            };

            //TODO: Log Request StartEvent
            Logger.RegisterError(transactionID, "call message", new Exception("Teste de exception"));

            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            RequestInfo.EndTime = DateTime.Now;
            base.OnActionExecuted(context);
            //TODO: Log Request EndEvent
        }
    }
}