using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BloggingEngine.Models;
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
}