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
                var posts = db.Posts.ToList();
                return posts;
            }
        }

        [HttpGet("GetPostById/{id}")]
        public async Task<Models.Post> GetPostById(int id)
        {
            using (var db = new Models.testAPIContext())
            {
                var post = await db.Posts.FindAsync(id);
                return post;
            }
        }

        [HttpGet("GetPostByUserId/{userId}")]
        public IEnumerable<Models.Post> GetPostByUserId(int userId)
        {
            using (var db = new Models.testAPIContext())
            {
                var posts = db.Posts.Where(p => p.UserId == userId).ToList();
                return posts;
            }
        }

        [HttpPost]
        public void AddPost(Models.Post post)
        {
            using (var db = new Models.testAPIContext())
            {
                db.Posts.Add(post);
                db.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        public void DeletePostById(int id)
        {
            using (var db = new Models.testAPIContext())
            {
                db.Posts.Remove(db.Posts.Find(id));
                db.SaveChanges();
            }
        }
    }
}
