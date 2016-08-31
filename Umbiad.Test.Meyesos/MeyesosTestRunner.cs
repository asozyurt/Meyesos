using System;
using System.Collections.Generic;
using System.Text;
using Umbiad.App.DataAccess.Meyesos;
using Umbiad.App.Service.Meyesos;
using Umbiad.Common.Messages.Meyesos;

namespace Umbiad.Test.Meyesos
{
    class MeyesosTestRunner
    {
        Dictionary<string, Action> testActions = new Dictionary<string, Action>();


        public MeyesosTestRunner()
        {
            //  testActions.Add("InsertUser", testUserInsert);
            testActions.Add("InsertTest", testMessageInsert);
        }

        private void testUserInsert()
        {
            UserDataAccessManager dataAccess = new UserDataAccessManager();

            dataAccess.InsertUser(new User
            {
                BirthDate = 19891113,
                Email = "asozyurt@gmail.com",
                Name = "Asozyurt",
                Password = "parola",
                PersonalMessage = "Buralarda yeniyim",
                Phone = "05446445235",
                UserName = "asozyurt",
                Status = Constants.USERSTATUS_ACTIVE
            });

        }

        private void testMessageInsert()
        {
            MessageService service = new MessageService();
            UserMessage result = new UserMessage
            {
                EntryDate = 20160828,
                EntryTime = 235800,
                UserName = "asozyurt",
                Message = "Fourth Message.Its over service"

            };
            service.AddMessage(result);

        }

        internal string RunAll()
        {
            StringBuilder resultMessages = new StringBuilder();

            foreach (var item in testActions)
            {
                resultMessages.Append(item.Key);
                try
                {
                    item.Value.Invoke();
                    resultMessages.Append(": Başarılı Tamamlandı");
                }
                catch (Exception e)
                {
                    resultMessages.Append(": Hata Aldı.");
                    resultMessages.AppendLine();
                    resultMessages.Append("---");
                    resultMessages.Append("Hata Detayı:");
                    resultMessages.Append(e.Message);
                }
                resultMessages.AppendLine();
            }

            return resultMessages.ToString();
        }
    }
}
