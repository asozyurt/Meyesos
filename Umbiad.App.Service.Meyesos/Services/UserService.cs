using Umbiad.App.DataAccess.Meyesos;
using Umbiad.Common.Messages.Meyesos;
using Umbiad.Common.Messages.Meyesos.Interfaces;

namespace Umbiad.App.Service.Meyesos
{
    public class UserService : IMessageService
    {
        public User AddUser(User newUser)
        {
            newUser.Status = Constants.USERSTATUS_ACTIVE;
            UserDataAccessManager userDataAccess = new UserDataAccessManager();
            return userDataAccess.Insert(newUser);
        }
        public User DeleteUser(User userToDelete)
        {
            userToDelete.Status = Constants.USERSTATUS_DELETED;
            UserDataAccessManager userDataAccess = new UserDataAccessManager();
            return userDataAccess.Update(userToDelete);
        }
        public User DeactivateUser(User userToDeactivate)
        {
            userToDeactivate.Status = Constants.USERSTATUS_PASSIVE;
            UserDataAccessManager userDataAccess = new UserDataAccessManager();
            return userDataAccess.Update(userToDeactivate);
        }
        public User UpdateUser(User userToUpdate)
        {
            UserDataAccessManager userDataAccess = new UserDataAccessManager();
            return userDataAccess.Update(userToUpdate);
        }
    }
}
