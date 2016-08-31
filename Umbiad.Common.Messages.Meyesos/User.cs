
namespace Umbiad.Common.Messages.Meyesos
{
    public class User : BaseMessage
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string PersonalMessage { get; set; }
        public int BirthDate { get; set; }

        public short Status { get; set; }
    }
}
