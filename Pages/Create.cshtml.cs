
using MicroBlog.Models;
using MicroBlog.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MicroBlog.Pages
{
    public class CreateModel : PageModel
    {
        private readonly PostService _postService;

        public CreateModel(PostService postService)
        {
            _postService = postService;
        }

        [BindProperty]
        public Post Post { get; set; } = new();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _postService.Add(Post);

            return RedirectToPage("/Index");
        }
    }
}