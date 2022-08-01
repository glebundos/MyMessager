using Newtonsoft.Json;
using System;

namespace MyMessager
{
    class Program
    {
        private static int MessageID;
        private static string UserName;
        private static MessangerClientAPI API = new();
        
        private static void GetNewMessages()
        {
            Message? msg = API.GetMessage(MessageID);
            while (msg != null)
            {
                Console.WriteLine(msg);
                MessageID++;
                msg = API.GetMessage(MessageID);
            }
        }
        
        static void Main(string[] args)
        {
            //Message msg = new Message(userName: "lzy77_", messageText: "Hello!", timeStamp: DateTime.UtcNow);
            //string output = JsonConvert.SerializeObject(msg);
            //Console.WriteLine(output);
            //Message? deseriazebledMsg = JsonConvert.DeserializeObject<Message>(output);
            //Console.WriteLine(deseriazebledMsg);
            //{ "UserName":"lzy77_","MessageText":"Hello!","TimeStamp":"2022-07-31T11:15:57.4803287Z"}
            //lzy77_ < вс 31.07.22 11:15:57 >: Hello!
            MessageID = 1;
            Console.WriteLine("Введите ваш ник");
            UserName = Console.ReadLine();
            string messageText = "";
            while (messageText != "exit")
            {
                GetNewMessages();
                Console.WriteLine("Введите сообщение");
                messageText = Console.ReadLine();
                if (messageText.Length > 0)
                {
                    Message msg = new Message(userName: UserName, messageText: messageText, timeStamp: DateTime.UtcNow);
                    API.SendMessage(msg);
                }
            }
        }
    }
}