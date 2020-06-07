using System.Collections.Generic;
using System.Linq;
//using InfoService.Models.DBModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace InfoService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientAppController : ControllerBase
    {

        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        //private ahmedalm_infobaseContext _infobaseContext;

        private readonly ILogger<ClientAppController> _logger;

        public ClientAppController(ILogger<ClientAppController> logger/*, ahmedalm_infobaseContext infobaseContext*/)
        {
            _logger = logger;
            //_infobaseContext = infobaseContext;
        }

        [HttpGet]
        public InfoServiceDataLayer.Models.Implementations.Clientapp Get(int id)
        {
            return null;
            //return _infobaseContext.Clientapp.FirstOrDefault(x => x.Idclientapp == id);
        }
    }
}
