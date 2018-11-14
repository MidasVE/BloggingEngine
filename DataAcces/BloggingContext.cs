using System;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkMvc.DataAccess
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> config) : base(config)
        {

        }

        public DbSet<Post> Post { get; internal set; }
        public DbSet<Comment> Comment { get; internal set; }
    }

    public class Post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string author { get; set; }
        public string date { get; set; }
    }

    public class Comment 
    {
        public int id { get; set; }
        public int postId { get; set; }
        public string text { get; set; }
    }
}