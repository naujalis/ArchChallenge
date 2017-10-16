using ArchChallenge.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchChallenge.ServiceA.Application
{
    public class SampleAApplication
    {
        public string DoSomething(Request requestInfo, string data)
        {
            // TODO: Log Event
            return ServiceB.Wrapper.SampleB.Post(requestInfo.TransactionID, "SampleA Application call with data -> " + data);
        }
    }
}