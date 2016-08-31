using Umbiad.Common.Messages.Meyesos;

namespace Umbiad.App.DataAccess.Meyesos.Mappers
{
    public class FollowInfoMapper
    {
        public static FollowInfo Convert(MYS_FOLLOWINFO dbMessage)
        {
            return new FollowInfo
            {
                Id = dbMessage.Id,
                UserId = dbMessage.UserId,
                EndDate = dbMessage.EndDate,
                EndTime = dbMessage.EndTime,
                IsActive = dbMessage.IsActive,
                StartDate = dbMessage.StartDate,
                StartTime = dbMessage.StartTime,
                OpponentUserId = dbMessage.OpponentUserId
            };
        }

        public static MYS_FOLLOWINFO ConvertToDBRecord(FollowInfo followInfo)
        {
            return new MYS_FOLLOWINFO
            {
                Id = followInfo.Id,
                UserId = followInfo.UserId,
                EndDate = followInfo.EndDate,
                EndTime = followInfo.EndTime,
                IsActive = followInfo.IsActive,
                StartDate = followInfo.StartDate,
                StartTime = followInfo.StartTime,
                OpponentUserId = followInfo.OpponentUserId
            };
        }
    }
}
