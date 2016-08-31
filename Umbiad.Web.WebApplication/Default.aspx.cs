using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Umbiad.Web.WebApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mesaj = Request.QueryString["Mesaj"];
            MessageServiceClient.MessageServiceClient client = new MessageServiceClient.MessageServiceClient("BasicHttpBinding_IMessageService");
            client.AddMessage(new MessageServiceClient.UserMessage
            {
                EntryDate = 20160829,
                EntryTime = 215800,
                UserName = "asozyurt",
                Message = "Seventh Message.Its over website. Also: " + mesaj
            });
        }
    }
}