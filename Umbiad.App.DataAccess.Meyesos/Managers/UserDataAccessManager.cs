using System.Linq;
using Umbiad.App.DataAccess.Meyesos.Mappers;
using Umbiad.Common.Messages.Meyesos;

namespace Umbiad.App.DataAccess.Meyesos
{
    public class UserDataAccessManager : DataAccessManager
    {
        public User Insert(User record)
        {
            MeyesosDBContainer container = new MeyesosDBContainer();
            MYS_USER newRecord = UserMapper.ConvertToDBRecord(record);

            var userMessage = container.Table_User.Add(newRecord);
            container.SaveChanges();

            record.Id = userMessage.Id;

            return record;
        }

        public User Update(User record)
        {
            MeyesosDBContainer container = new MeyesosDBContainer();
            MYS_USER updatedRecord = UserMapper.ConvertToDBRecord(record);
            var user = container.Table_User.Attach(updatedRecord);

            if (container.SaveChanges() == 1)
            {
                record.Id = user.Id;
            }
            return record;
        }

        public bool Delete(User record)
        {
            MeyesosDBContainer container = new MeyesosDBContainer();
            container.Table_User.Remove(container.Table_User.Find(record.Id));
            return container.SaveChanges() == 1;
        }

        public User Get(User record)
        {
            MeyesosDBContainer container = new MeyesosDBContainer();
            var dbRecord = container.Table_User.Where(x => x.Id.Equals(record.Id) && x.Status.Equals(Constants.USERSTATUS_ACTIVE)).FirstOrDefault();

            return UserMapper.Convert(dbRecord);
        }
        public User GetByUserName(User record)
        {
            MeyesosDBContainer container = new MeyesosDBContainer();
            var dbRecord = container.Table_User.Where(x => x.UserName.Equals(record.UserName) && x.Status.Equals(Constants.USERSTATUS_ACTIVE)).FirstOrDefault();

            return UserMapper.Convert(dbRecord);
        }
    }
}
