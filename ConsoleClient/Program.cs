using Newtonsoft.Json;
using System;

namespace MyMessager
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message(userName: "lzy77_", messageText: "Hello!", timeStamp: DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message? deseriazebledMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deseriazebledMsg);

            //{ "UserName":"lzy77_","MessageText":"Hello!","TimeStamp":"2022-07-31T11:15:57.4803287Z"}
            //lzy77_ < вс 31.07.22 11:15:57 >: Hello!
        }
    }
}