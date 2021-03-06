using Microsoft.AspNetCore.Mvc;
using BloggingEngine.Models;
using System.Collections.Generic;
using System;
using EntityFrameworkMvc.DataAccess;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet("blog/detail/{postId}")]
        public IActionResult Detail([FromRoute] int postId) {
            Post blogPost = _bloggingContext.Post.Include(b => b.Comments).Where(b => b.id == postId).FirstOrDefault();
            return View(blogPost);
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost([FromForm] Post p) {
            if (ModelState.IsValid) {
                var post = new Post {
                    title = p.title,
                    content = p.content,
                    author = p.author,
                    date = p.date
                };

                _bloggingContext.Add < Post > (post);
                _bloggingContext.SaveChanges();

                return RedirectToAction("Index");
            }
            return View("Create");            
        }

        public IActionResult Delete([FromRoute] int id) {
            var blogPost = _bloggingContext.Post.Where(b => b.id == id).FirstOrDefault();
            _bloggingContext.Remove < Post > (blogPost);
            _bloggingContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit([FromRoute] int id) {
            var blogPost = _bloggingContext.Post.Where(b => b.id == id).FirstOrDefault();
            return View(blogPost);
        }

        [HttpPost]
        public IActionResult Edit([FromForm] Post p) {
            var blogPost = _bloggingContext.Post.Where(b => b.id == p.id).FirstOrDefault();

            if (ModelState.IsValid) {                
                blogPost.title = p.title;
                blogPost.content = p.content;
                blogPost.author = p.author;
                blogPost.date = p.date;
                _bloggingContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(blogPost);            
        }

        [HttpPost]
        public IActionResult Comment([FromForm] Comment c) {
            var comment = new Comment {
                text = c.text,
                postId = c.postId
            };

            _bloggingContext.Add < Comment > (comment);
            _bloggingContext.SaveChanges();

            return RedirectToAction("Detail", new {id = c.postId});
        }
    }
}