
using MicroBlog.Models;
using MicroBlog.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MicroBlog.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PostService _postService;

        public List<Post> Posts { get; set; } = new();

        public IndexModel(PostService postService)
        {
            _postService = postService;
        }

        public void OnGet()
        {
            Posts = _postService.GetAll();
        }
    }
}