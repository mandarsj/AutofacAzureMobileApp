using System.Web.Http;
using Microsoft.Azure.Mobile.Server.Config;
using Newtonsoft.Json;

namespace AutofacAzureMobileApp.Controllers
{
    // Use the MobileAppController attribute for each ApiController you want to use  
    // from your mobile clients 
    [MobileAppController]
    public class ValuesController : ApiController
    {
        private JsonSerializerSettings _settings;
        public ValuesController(JsonSerializerSettings settings)
        {
            _settings = settings;
        }
        // GET api/values
        public string Get()
        {
            var checksetting = _settings;
            return "Hello World!";
        }

        // POST api/values
        public string Post()
        {
            return "Hello World!";
        }
    }
}
