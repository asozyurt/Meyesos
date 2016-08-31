using System.ServiceModel;

namespace Umbiad.Common.Messages.Meyesos.Interfaces
{
    [ServiceContract]
    public interface IMessageService
    {
        [OperationContract]
        UserMessage AddMessage(UserMessage message);
        UserMessage UpdateMessage(UserMessage message);
        UserMessage DeleteMessage(UserMessage message);

    }
}
