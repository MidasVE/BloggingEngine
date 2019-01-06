using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EntityFrameworkMvc.DataAccess;

namespace BloggingEngine.Models {
    public class PostCreateViewModel
    {
        public Post Post { get; set; }
    }

     public class Post
    {
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string content { get; set; }
        [Required]
        public string author { get; set; }
        public string date { get; set; }
        public List<Comment> Comments { get; set; }      
    }

    public class Comment 
    {
        public int id { get; set; }
        public int postId { get; set; }
        [Required]
        public string text { get; set; }
        public Post post { get; set; }
    }
}