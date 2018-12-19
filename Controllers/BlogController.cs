using Microsoft.AspNetCore.Mvc;
using BloggingEngine.Models;
using System.Collections.Generic;
using System;
using EntityFrameworkMvc.DataAccess;
using System.Linq;

namespace BloggingEngine.Controllers {
    public class BlogController: Controller {
        private BloggingContext _bloggingContext;

        public BlogController(BloggingContext blogContext) {
            _bloggingContext = blogContext;
        }

        [PokeActionFilter]
        public IActionResult Index() {
            var blogPosts = _bloggingContext.Post.ToList();
            var list = new Blog();
            list.Posts = blogPosts;
            return View(list);
        }

        public IActionResult Detail([FromRoute] int id) {
            var blogPost = _bloggingContext.Post.Where(b => b.id == id).FirstOrDefault();
            return View(blogPost);
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost([FromForm] Post p) {
            var post = new Post {
                title = p.title,
                content = p.content,
                author = p.author,
                date = p.date
            };

            _bloggingContext.Add < Post > (post);
            _bloggingContext.SaveChanges();
            // model bijmaken in bloggingcontext voor blogdetail + comments
            return RedirectToAction("Index");
        }

        public IActionResult Delete([FromRoute] int id) {
            var blogPost = _bloggingContext.Post.Where(b => b.id == id).FirstOrDefault();
            _bloggingContext.Remove < Post > (blogPost);
            _bloggingContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit([FromRoute] int id) {
            var blogPost = _bloggingContext.Post.Where(b => b.id == id).FirstOrDefault();
            return View(blogPost);
        }

        public IActionResult EditPost([FromForm] Post p) {
            var blogPost = _bloggingContext.Post.Where(b => b.id == p.id).FirstOrDefault();

            blogPost.title = p.title;
            blogPost.content = p.content;
            blogPost.author = p.author;
            blogPost.date = p.date;
            _bloggingContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Comment([FromForm] Comment c) {
            var comment = new Comment {
                text = c.text,
                postId = c.postId
            };

            _bloggingContext.Add < Comment > (comment);
            _bloggingContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult ViewComments ([FromRoute] int id) {
            var comments = _bloggingContext.Comment.Where(c => c.postId == id).ToList();
            var list = new CommentList();
            list.Comments = comments;
            return View(list);
        }
    }
}