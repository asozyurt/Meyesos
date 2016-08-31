
namespace Umbiad.Common.Messages.Meyesos
{
    public class FollowInfo : BaseMessage
    {
        public long UserId { get; set; }
        public long OpponentUserId { get; set; }
        public bool IsActive { get; set; }
        public int StartDate { get; set; }
        public int StartTime { get; set; }
        public int EndDate { get; set; }
        public int EndTime { get; set; }
    }
}
