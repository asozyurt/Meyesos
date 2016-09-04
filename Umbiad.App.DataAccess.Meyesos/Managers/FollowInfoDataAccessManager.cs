using System.Collections.Generic;
using System.Linq;
using Umbiad.App.DataAccess.Meyesos.Mappers;
using Umbiad.Common.Messages.Meyesos;

namespace Umbiad.App.DataAccess.Meyesos
{
    public class FollowInfoDataAccessManager : MeyesosDataAccessManager
    {
        public FollowInfo Insert(FollowInfo record)
        {
            MYS_FOLLOWINFO newRecord = FollowInfoMapper.ConvertToDBRecord(record);

            var dbRecord = Container.Table_FollowInfo.Add(newRecord);
            if (Container.SaveChanges() == 1)
            {
                record.Id = dbRecord.Id;
            }
            return record;
        }

        public FollowInfo Update(FollowInfo record)
        {
            MYS_FOLLOWINFO updatedRecord = FollowInfoMapper.ConvertToDBRecord(record);
            var dbRecord = Container.Table_FollowInfo.Attach(updatedRecord);

            if (Container.SaveChanges() == 1)
            {
                record.Id = dbRecord.Id;
            }
            return record;
        }

        public bool Delete(FollowInfo record)
        {
            Container.Table_FollowInfo.Remove(Container.Table_FollowInfo.Find(record.Id));
            return Container.SaveChanges() == 1;
        }

        public FollowInfo Get(FollowInfo record)
        {
            var dbRecord = Container.Table_FollowInfo.Find(record.Id);

            return FollowInfoMapper.Convert(dbRecord);
        }

        public List<FollowInfo> GetByUser(FollowInfo followInfo)
        {
            var dbRecords = Container.Table_FollowInfo.Where(x => x.UserId.Equals(followInfo.UserId));
            List<FollowInfo> result = new List<FollowInfo>();

            dbRecords.ToList().ForEach(x => result.Add(FollowInfoMapper.Convert(x)));
            return result;
        }
    }
}
