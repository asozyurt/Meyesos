using System;
using System.Collections.Generic;
using System.Linq;
using Umbiad.App.DataAccess.Meyesos.Mappers;
using Umbiad.Common.Messages.Meyesos;

namespace Umbiad.App.DataAccess.Meyesos
{
    public class MessageDataAccessManager : MeyesosDataAccessManager
    {
        public UserMessage Insert(UserMessage record)
        {
            MYS_MESSAGE newRecord = UserMessageMapper.ConvertToDBRecord(record);

            var dbRecord = Container.Table_Message.Add(newRecord);
            if (Container.SaveChanges() == 1)
            {
                record.Id = dbRecord.Id;
            }

            return record;
        }

        public UserMessage Update(UserMessage record)
        {
            MYS_MESSAGE updatedRecord = UserMessageMapper.ConvertToDBRecord(record);
            var dbRecord = Container.Table_Message.Attach(updatedRecord);

            if (Container.SaveChanges() == 1)
            {
                record.Id = dbRecord.Id;
            }
            return record;
        }

        public UserMessage BulkUpdateByUser(UserMessage record)
        {
            MYS_MESSAGE updatedRecord = UserMessageMapper.ConvertToDBRecord(record);
            Container.Table_Message.Where(x => x.UserId.Equals(record.UserId)).ToList().ForEach(y => Container.Table_Message.Attach(y));

            if (Container.SaveChanges() == 0)
            {
                throw new Exception("Silinecek kayıt bulunamadı.");
            }
            return record;
        }
        public bool Delete(UserMessage record)
        {
            MYS_MESSAGE updatedRecord = UserMessageMapper.ConvertToDBRecord(record);
            var dbRecord = Container.Table_Message.Attach(updatedRecord);
            updatedRecord.Status = Constants.MESSAGESTATUS_DELETED;

            return Container.SaveChanges() == 1;
        }
        public bool PermanentlyDelete(UserMessage record)
        {
            var userMessage = Container.Table_Message.Remove(Container.Table_Message.Find(record.Id));
            return DbContainer.SaveChanges() == 1;
        }

        public UserMessage Get(UserMessage record)
        {
            var dbRecord = Container.Table_Message.Find(record.Id);
            return UserMessageMapper.Convert(dbRecord);
        }

        public List<UserMessage> GetByUser(UserMessage message)
        {
            var dbRecord = Container.Table_Message.Where(x => x.UserId.Equals(message.UserId));
            List<UserMessage> result = new List<UserMessage>();

            dbRecord.ToList().ForEach(x => result.Add(UserMessageMapper.Convert(x)));
            return result;
        }
    }
}
