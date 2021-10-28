using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Models.Post> GetAllPosts()
        {
            using (var db = new Models.testAPIContext())
            {
                IEnumerable<Models.Post> posts = db.Posts.ToList();
                return posts;
            }
        }
    }
}
