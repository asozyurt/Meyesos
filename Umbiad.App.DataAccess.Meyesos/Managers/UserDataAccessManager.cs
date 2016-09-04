using System.Linq;
using Umbiad.App.DataAccess.Meyesos.Mappers;
using Umbiad.Common.Messages.Meyesos;

namespace Umbiad.App.DataAccess.Meyesos
{
    public class UserDataAccessManager : MeyesosDataAccessManager
    {
        public User Insert(User record)
        {
            MYS_USER newRecord = UserMapper.ConvertToDBRecord(record);

            var userMessage = Container.Table_User.Add(newRecord);
            Container.SaveChanges();

            record.Id = userMessage.Id;

            return record;
        }

        public User Update(User record)
        {
            MYS_USER updatedRecord = UserMapper.ConvertToDBRecord(record);
            var user = Container.Table_User.Attach(updatedRecord);

            if (Container.SaveChanges() == 1)
            {
                record.Id = user.Id;
            }
            return record;
        }

        public bool Delete(User record)
        {
            Container.Table_User.Remove(Container.Table_User.Find(record.Id));
            return Container.SaveChanges() == 1;
        }

        public User Get(User record)
        {
            var dbRecord = Container.Table_User.Where(x => x.Id.Equals(record.Id) && x.Status.Equals(Constants.USERSTATUS_ACTIVE)).FirstOrDefault();

            return UserMapper.Convert(dbRecord);
        }
        public User GetByUserName(User record)
        {
            var dbRecord = Container.Table_User.Where(x => x.UserName.Equals(record.UserName) && x.Status.Equals(Constants.USERSTATUS_ACTIVE)).FirstOrDefault();

            return UserMapper.Convert(dbRecord);
        }
    }
}
