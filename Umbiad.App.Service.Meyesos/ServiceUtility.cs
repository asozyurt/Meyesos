
using System;
using Umbiad.App.DataAccess.Meyesos;
using Umbiad.Common.Messages.Meyesos;
namespace Umbiad.App.Service.Meyesos
{
    public class ServiceUtility
    {
        public static long FindUserIdFromUserName(string userName)
        {
            UserDataAccessManager dataAccess = new UserDataAccessManager();
            var user = dataAccess.GetByUserName(new User { UserName = userName });
            if (user == null)
                throw new Exception("User Cannot Be Found");
            return user.Id;
        }
    }
}
