using System.ServiceModel;

namespace Umbiad.Common.Messages.Meyesos.Interfaces
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        UserMessage AddUser(User user);
        UserMessage UpdateUser(User user);
        UserMessage DeleteUser(User user);

    }
}
