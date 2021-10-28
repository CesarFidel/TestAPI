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

        /// <summary>
        /// Obtiene todos los posts
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Models.Post> GetAllPosts() 
        {
            using (var db = new Models.testAPIContext()) //Crea la conexión con la base de datos
            {
                var posts = db.Posts.ToList();
                return posts;
            }
        }

        /// <summary>
        /// Obtiene un post dependiendo de su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetPostById/{id}")]
        public async Task<Models.Post> GetPostById(int id)
        {
            using (var db = new Models.testAPIContext()) //Crea la conexión con la base de datos
            {
                var post = await db.Posts.FindAsync(id);
                return post;
            }
        }

        /// <summary>
        /// Obtiene un post ó más dependiendo de su UserId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("GetPostByUserId/{userId}")]
        public IEnumerable<Models.Post> GetPostByUserId(int userId)
        {
            using (var db = new Models.testAPIContext()) //Crea la conexión con la base de datos
            {
                var posts = db.Posts.Where(p => p.UserId == userId).ToList();
                return posts;
            }
        }

        /// <summary>
        /// Añade un post
        /// </summary>
        /// <param name="post"></param>
        [HttpPost]
        public void AddPost(Models.Post post)
        {
            using (var db = new Models.testAPIContext()) //Crea la conexión con la base de datos
            {
                db.Posts.Add(post);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Borra un post dependiendo de su id
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void DeletePostById(int id)
        {
            using (var db = new Models.testAPIContext()) //Crea la conexión con la base de datos
            {
                db.Posts.Remove(db.Posts.Find(id));
                db.SaveChanges();
            }
        }
    }
}
