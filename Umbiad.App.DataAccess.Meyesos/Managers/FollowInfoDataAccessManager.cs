using System.Collections.Generic;
using System.Linq;
using Umbiad.App.DataAccess.Meyesos.Mappers;
using Umbiad.Common.Messages.Meyesos;

namespace Umbiad.App.DataAccess.Meyesos
{
    public class FollowInfoDataAccessManager : DataAccessManager
    {
        public FollowInfo Insert(FollowInfo record)
        {
            MeyesosDBContainer container = new MeyesosDBContainer();
            MYS_FOLLOWINFO newRecord = FollowInfoMapper.ConvertToDBRecord(record);

            var dbRecord = container.Table_FollowInfo.Add(newRecord);
            container.SaveChanges();

            record.Id = dbRecord.Id;

            return record;
        }

        public FollowInfo Update(FollowInfo record)
        {
            MeyesosDBContainer container = new MeyesosDBContainer();
            MYS_FOLLOWINFO updatedRecord = FollowInfoMapper.ConvertToDBRecord(record);
            var dbRecord = container.Table_FollowInfo.Attach(updatedRecord);

            if (container.SaveChanges() == 1)
            {
                record.Id = dbRecord.Id;
            }
            return record;
        }

        public bool Delete(FollowInfo record)
        {
            MeyesosDBContainer container = new MeyesosDBContainer();
            container.Table_FollowInfo.Remove(container.Table_FollowInfo.Find(record.Id));
            return container.SaveChanges() == 1;
        }

        public FollowInfo Get(FollowInfo record)
        {
            MeyesosDBContainer container = new MeyesosDBContainer();
            var dbRecord = container.Table_FollowInfo.Find(record.Id);

            return FollowInfoMapper.Convert(dbRecord);
        }

        public List<FollowInfo> GetByUser(FollowInfo followInfo)
        {
            MeyesosDBContainer container = new MeyesosDBContainer();
            var dbRecord = container.Table_FollowInfo.Where(x => x.UserId.Equals(followInfo.UserId));
            List<FollowInfo> result = new List<FollowInfo>();

            dbRecord.ToList().ForEach(x => result.Add(FollowInfoMapper.Convert(x)));
            return result;
        }
    }
}
