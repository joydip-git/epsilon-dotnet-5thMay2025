using BasicASPNETApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicASPNETApp.Controllers
{
    [ApiController]
    //all methods of this controller class will have a prefix in the URL -> api/Contact
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private ContactDao contactDao;

        public ContactController() => contactDao = new ContactDao();

        //actions
        [HttpGet]
        [Route("all")]// URL: api/Contact/all        
        public List<string> GetContacts()
        {
            return contactDao.FetchContacts();
        }

        [HttpGet]
        [Route("{name}")] //name -> route parameter
        //public string GetContact(string name)
        public string GetContact([FromRoute(Name = "name")] string personName)
        {
            return contactDao.FetchContact(personName);
        }
    }
}
