using System.Collections.Generic;
using Umbiad.App.DataAccess.Meyesos;
using Umbiad.Common.Messages.Meyesos;
using Umbiad.Common.Messages.Meyesos.Interfaces;

namespace Umbiad.App.Service.Meyesos
{
    public class MessageService : IMessageService
    {
        public UserMessage AddMessage(UserMessage message)
        {
            if (message.UserId == 0L)
            {
                message.UserId = ServiceUtility.FindUserIdFromUserName(message.UserName);
            }
            message.Status = Constants.MESSAGESTATUS_NEW;
            MessageDataAccessManager messageDataAccess = new MessageDataAccessManager();
            return messageDataAccess.Insert(message);
        }

        public UserMessage DeleteMessage(UserMessage message)
        {
            if (message.UserId == 0L)
            {
                message.UserId = ServiceUtility.FindUserIdFromUserName(message.UserName);
            }
            message.Status = Constants.MESSAGESTATUS_DELETED;
            MessageDataAccessManager messageDataAccess = new MessageDataAccessManager();
            return messageDataAccess.Update(message);
        }

        public UserMessage DeleteMessagesByUser(UserMessage message)
        {
            if (message.UserId == 0L)
            {
                message.UserId = ServiceUtility.FindUserIdFromUserName(message.UserName);
            }
            message.Status = Constants.MESSAGESTATUS_DELETED;
            MessageDataAccessManager messageDataAccess = new MessageDataAccessManager();
            return messageDataAccess.BulkUpdateByUser(message);
        }

        public bool PermanentlyDeleteMessage(UserMessage message)
        {
            if (message.UserId == 0L)
            {
                message.UserId = ServiceUtility.FindUserIdFromUserName(message.UserName);
            }
            MessageDataAccessManager messageDataAccess = new MessageDataAccessManager();
            return messageDataAccess.Delete(message);
        }

        public UserMessage UpdateMessage(UserMessage message)
        {
            if (message.UserId == 0L)
            {
                message.UserId = ServiceUtility.FindUserIdFromUserName(message.UserName);
            }
            MessageDataAccessManager messageDataAccess = new MessageDataAccessManager();
            return messageDataAccess.Update(message);
        }

        public UserMessage GetMessage(UserMessage message)
        {
            MessageDataAccessManager messageDataAccess = new MessageDataAccessManager();
            return messageDataAccess.Get(message);
        }
        public List<UserMessage> GetMessagesByUser(UserMessage message)
        {
            if (message.UserId == 0)
                message.UserId = ServiceUtility.FindUserIdFromUserName(message.UserName);

            MessageDataAccessManager messageDataAccess = new MessageDataAccessManager();
            return messageDataAccess.GetByUser(message);
        }
    }
}
