using GraphQL.AttachedResourceInterfaces;
using GraphQLDemo.Data.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GraphQLDemo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {


        private readonly ILogger<DemoController> _logger;
        private readonly IDataStore dataStore;

        public DemoController(ILogger<DemoController> logger, IDataStore dataStore)
        {
            _logger = logger;
            this.dataStore = dataStore;
        }

        [HttpGet(Name = "GetDemoProfile")]
        public ActionResult<Profile> Get()
        {
            return dataStore.ProfilesRepository.GetById(Guid.Parse("e9bdbcd4-c6e6-4eda-aed9-b9c79e844182"));
        }
    }
}