using Umbiad.Common.Messages.Meyesos;

namespace Umbiad.App.DataAccess.Meyesos.Mappers
{
    public class UserMessageMapper
    {
        public static UserMessage Convert(MYS_MESSAGE dbMessage)
        {
            return new UserMessage
            {
                Id = dbMessage.Id,
                UserId = dbMessage.UserId,
                Message = dbMessage.Message,
                EntryDate = dbMessage.EntryDate,
                EntryTime = dbMessage.EntryTime,
                Media = dbMessage.Media,
                MediaType = dbMessage.MediaType,
                Status = dbMessage.Status

            };
        }

        public static MYS_MESSAGE ConvertToDBRecord(UserMessage userMessage)
        {
            return new MYS_MESSAGE
            {
                Id = userMessage.Id,
                UserId = userMessage.UserId,
                Message = userMessage.Message,
                EntryDate = userMessage.EntryDate,
                EntryTime = userMessage.EntryTime,
                Media = userMessage.Media,
                MediaType = userMessage.MediaType,
                Status = userMessage.Status
            };
        }
    }
}
