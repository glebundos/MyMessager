using Microsoft.AspNetCore.Mvc;
using MyMessager;
using Newtonsoft.Json;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPCoreServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Messanger : ControllerBase
    {
        static List<Message> ListOfMessages = new List<Message>();
        
        // GET api/<Messanger>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            string output = "Not found";
            if (id < ListOfMessages.Count && id >= 0)
            {
                output = JsonConvert.SerializeObject(ListOfMessages[id]);
            }

            Console.WriteLine(String.Format("Requested message №{0} : {1}", id, output));
            return output;
        }

        // POST api/<Messanger>
        [HttpPost]
        public IActionResult SendMessage([FromBody] Message msg)
        {
            if (msg == null)
            {
                return BadRequest();
            }

            ListOfMessages.Add(msg);
            Console.WriteLine(String.Format("Total messages {0} \nRecieved message: {1}", ListOfMessages.Count, msg));
            return new OkResult();
        }
    }
}
