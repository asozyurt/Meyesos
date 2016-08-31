using System.Collections.Generic;
using Umbiad.App.DataAccess.Meyesos;
using Umbiad.Common.Messages.Meyesos;
using Umbiad.Common.Messages.Meyesos.Interfaces;

namespace Umbiad.App.Service.Meyesos
{
    public class FollowInfoService : IMessageService
    {
        public FollowInfo AddNewFollowInfo(FollowInfo newFollowInfo)
        {
            FollowInfoDataAccessManager followInfoDataAccess = new FollowInfoDataAccessManager();
            return followInfoDataAccess.Insert(newFollowInfo);
        }
        public FollowInfo DeleteFollowInfo(FollowInfo followInfoToDelete)
        {
            FollowInfoDataAccessManager followInfoDataAccess = new FollowInfoDataAccessManager();
            return followInfoDataAccess.Update(followInfoToDelete);
        }

        public List<FollowInfo> GetFollowInfoByUser(FollowInfo followInfo)
        {
            FollowInfoDataAccessManager followInfoDataAccess = new FollowInfoDataAccessManager();
            return followInfoDataAccess.GetByUser(followInfo);
        }

    }
}
