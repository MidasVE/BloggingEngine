using EntityFrameworkMvc.DataAccess;
using System.Collections.Generic;

namespace BloggingEngine.Models
{
    public class CommentList
    {
        public List<Comment> Comments { get; set; }
    }
}