using System;
using System.Collections.Generic;
using System.Linq;
using Umbiad.App.DataAccess.Meyesos.Mappers;
using Umbiad.Common.Messages.Meyesos;

namespace Umbiad.App.DataAccess.Meyesos
{
    public class MessageDataAccessManager : DataAccessManager
    {
        public UserMessage Insert(UserMessage record)
        {
            MeyesosDBContainer container = new MeyesosDBContainer();
            MYS_MESSAGE newRecord = UserMessageMapper.ConvertToDBRecord(record);

            var userMessage = container.Table_Message.Add(newRecord);
            container.SaveChanges();

            record.Id = userMessage.Id;

            return record;
        }

        public UserMessage Update(UserMessage record)
        {
            MeyesosDBContainer container = new MeyesosDBContainer();
            MYS_MESSAGE updatedRecord = UserMessageMapper.ConvertToDBRecord(record);
            var userMessage = container.Table_Message.Attach(updatedRecord);

            if (container.SaveChanges() == 1)
            {
                record.Id = userMessage.Id;
            }
            return record;
        }

        public UserMessage BulkUpdateByUser(UserMessage record)
        {
            MeyesosDBContainer container = new MeyesosDBContainer();
            MYS_MESSAGE updatedRecord = UserMessageMapper.ConvertToDBRecord(record);
            container.Table_Message.Where(x => x.UserId.Equals(record.UserId)).ToList().ForEach(y => container.Table_Message.Attach(y));

            if (container.SaveChanges() == 0)
            {
                throw new Exception("Silinecek kayıt bulunamadı.");
            }
            return record;
        }
        public bool Delete(UserMessage record)
        {
            MeyesosDBContainer container = new MeyesosDBContainer();
            MYS_MESSAGE updatedRecord = UserMessageMapper.ConvertToDBRecord(record);
            var userMessage = container.Table_Message.Attach(updatedRecord);
            updatedRecord.Status = Constants.MESSAGESTATUS_DELETED;

            return container.SaveChanges() == 1;
        }
        public bool PermanentlyDelete(UserMessage record)
        {
            MeyesosDBContainer container = new MeyesosDBContainer();
            var userMessage = container.Table_Message.Remove(container.Table_Message.Find(record.Id));
            return container.SaveChanges() == 1;
        }

        public UserMessage Get(UserMessage record)
        {
            MeyesosDBContainer container = new MeyesosDBContainer();
            var dbRecord = container.Table_Message.Find(record.Id);

            return UserMessageMapper.Convert(dbRecord);
        }

        public List<UserMessage> GetByUser(UserMessage message)
        {
            MeyesosDBContainer container = new MeyesosDBContainer();
            var dbRecord = container.Table_Message.Where(x => x.UserId.Equals(message.UserId));
            List<UserMessage> result = new List<UserMessage>();

            dbRecord.ToList().ForEach(x => result.Add(UserMessageMapper.Convert(x)));
            return result;
        }
    }
}
