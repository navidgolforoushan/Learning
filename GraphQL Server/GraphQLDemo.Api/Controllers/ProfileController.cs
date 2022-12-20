using GraphQL.AttachedResourceInterfaces;
using GraphQLDemo.Data.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GraphQLDemo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : Controller
    {
        [HttpGet(Name = "GetProfile")]

        public ActionResult<string> Get()
        {
            return Ok("Profile!");
        }
    }
}
