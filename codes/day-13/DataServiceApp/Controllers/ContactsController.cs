using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DataServiceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public List<string> GetContacts() => ["anil", "sunil"];
    }
}
