namespace Umbiad.Common.Messages.Meyesos
{
    public class UserMessage : BaseMessage
    {
        private short status;

        public short Status
        {
            get { return status; }
            set { status = value; }
        }


        private string message;
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }


        public int EntryDate { get; set; }

        public int EntryTime { get; set; }

        public long Id { get; set; }

        public string Media { get; set; }

        // public System.Data.Entity.Spatial.DbGeography Location { get; set; }
        public string MediaType { get; set; }

        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                OnPropertyChanged("Message");
            }
        }
        public long UserId { get; set; }
    }
}
