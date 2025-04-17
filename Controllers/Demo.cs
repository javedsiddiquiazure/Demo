using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Demo : Controller
    {
        private static readonly List<User> _users = new List<User>
        {
            new User { ID = 10, Name = "Alpha", Age = 23 },
            new User { ID = 11, Name = "Peter", Age = 22 }
        };

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUser()
        {
            return _users;
        }
    }

    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
