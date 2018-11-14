using EntityFrameworkMvc.DataAccess;
using System.Collections.Generic;

namespace BloggingEngine.Models
{
    public class Blog
    {
        public List<Post> Posts { get; set; }
    }
}