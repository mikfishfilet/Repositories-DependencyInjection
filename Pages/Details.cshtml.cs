
using MicroBlog.Models;
using MicroBlog.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MicroBlog.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly PostService _postService;

        public Post? Post { get; set; }

        public DetailsModel(PostService postService)
        {
            _postService = postService;
        }

        public IActionResult OnGet(int id)
        {
            Post = _postService.GetById(id);

            if (Post == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}