using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbiad.Test.ClientApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageServiceReference.MessageServiceClient refService = new MessageServiceReference.MessageServiceClient("BasicHttpBinding_IMessageService");
            refService.AddMessage(new MessageServiceReference.UserMessage
            {
                EntryDate = 20160829,
                EntryTime = 213000,
                UserName = "asozyurt",
                Message = "Sixth Message.Its over service client"
            });
        }
    }
}
