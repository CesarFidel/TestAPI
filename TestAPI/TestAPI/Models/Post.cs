using System;
using System.Collections.Generic;

#nullable disable

namespace TestAPI.Models
{
    public partial class Post
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Boby { get; set; }
    }
}
