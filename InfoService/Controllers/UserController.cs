using System.Collections.Generic;
using System.Linq;
using InfoServiceDataLayer.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace InfoService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        private readonly ILogger<ClientAppController> _logger;
        private readonly IUserRepository _userRepository;

        public UserController(ILogger<ClientAppController> logger, IUserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
            //_infobaseContext = infobaseContext;
        }

        [HttpGet]
        public InfoServiceDataLayer.Models.Interfaces.IUser Get(int id)
        {
            return _userRepository.Get(id).FirstOrDefault();
        }

        [HttpPut]
        public bool Put(InfoServiceDataLayer.Models.Interfaces.IUser user)
        {
            return _userRepository.Update(user);
        }
    }
}
