using System.ServiceModel;

namespace Umbiad.Common.Messages.Meyesos.Interfaces
{
    [ServiceContract]
    public interface IFollowInfo
    {
        [OperationContract]
        UserMessage AddFollowInfo(FollowInfo info);
        UserMessage UpdateFollowInfo(FollowInfo info);
        UserMessage DeleteFollowInfo(FollowInfo info);

    }
}
