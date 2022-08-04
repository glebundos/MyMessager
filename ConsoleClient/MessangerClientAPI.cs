using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyMessager
{
    public class MessangerClientAPI
    {
        private static readonly HttpClient client = new ();
        public void TestNewtonsoftJson()
        {
            Message msg = new Message(userName: "lzy77_", messageText: "Hello!", timeStamp: DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message? deseriazebledMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deseriazebledMsg);

            //{ "UserName":"lzy77_","MessageText":"Hello!","TimeStamp":"2022-07-31T11:15:57.4803287Z"}
            //lzy77_ < вс 31.07.22 11:15:57 >: Hello!
        }

        public Message? GetMessage(int messageId)
        {
            WebRequest request = WebRequest.Create("http://localhost:5000/api/Messanger/" + messageId.ToString());
            request.Method = "GET";
            WebResponse response = request.GetResponse();
            string status = ((HttpWebResponse)response).StatusDescription;
            Stream output = response.GetResponseStream();
            StreamReader reader = new StreamReader(output);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            output.Close();
            response.Close();
            
            if ((status.ToLower() == "ok") && (responseFromServer != "Not found"))
            {
                return JsonConvert.DeserializeObject<Message>(responseFromServer);
            }
            else
            {
                return null;
            }
        }

        public async Task<Message?> GetMessageHTTPAsync(int MessageID)
        {
            try
            {
                var response = await client.GetAsync("http://localhost:5000/api/Messanger/" + MessageID.ToString());
                if (response != null)
                {
                    return JsonConvert.DeserializeObject<Message>(response.Content.ReadAsStringAsync().Result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public bool SendMessage(Message msg)
        {
            WebRequest request = WebRequest.Create("http://localhost:5000/api/Messanger");
            request.Method = "POST";
            request.ContentType = "application/json";
            string json = JsonConvert.SerializeObject(msg);
            byte[] data = Encoding.UTF8.GetBytes(json);
            request.ContentLength = data.Length;
            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);
            stream.Close();
            WebResponse response;
            try
            {
                response = request.GetResponse();
                string status = ((HttpWebResponse)response).StatusDescription;
                stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                string responseFromServer = reader.ReadToEnd();
                response.Close();
                reader.Close();
                stream.Close();
                return (status.ToLower() == "ok");
            }
            catch (Exception)
            {
                return false;   
            }
        }
    }
}
