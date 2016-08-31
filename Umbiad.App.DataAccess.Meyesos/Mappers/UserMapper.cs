using Umbiad.Common.Messages.Meyesos;

namespace Umbiad.App.DataAccess.Meyesos.Mappers
{
    public class UserMapper
    {
        public static User Convert(MYS_USER dbRecord)
        {
            if (dbRecord == null)
                return null;

            return new User
            {
                Id = dbRecord.Id,
                UserName = dbRecord.UserName,
                Email = dbRecord.Email,
                Name = dbRecord.Name,
                Password = dbRecord.Password,
                PersonalMessage = dbRecord.PersonalMessage,
                Phone = dbRecord.Phone,
                Status = dbRecord.Status
            };
        }

        public static MYS_USER ConvertToDBRecord(User user)
        {
            return new MYS_USER
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                Name = user.Name,
                Password = user.Password,
                PersonalMessage = user.PersonalMessage,
                Phone = user.Phone,
                BirthDate = user.BirthDate,
                Status = user.Status
            };
        }
    }
}
