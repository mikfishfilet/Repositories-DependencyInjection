
using System.Text.Json;
using MicroBlog.Models;

namespace MicroBlog.Services
{
    public class PostService
    {
        private readonly string _filePath;
        private readonly List<Post> _posts = new();
        private readonly object _lock = new();

        public PostService(IWebHostEnvironment environment)
        {
           
            string dataFolder = Path.Combine(
                environment.ContentRootPath, "data");

            Directory.CreateDirectory(dataFolder);

            _filePath = Path.Combine(dataFolder, "posts.json");

            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);

                _posts = JsonSerializer.Deserialize<List<Post>>(json)
                         ?? new List<Post>();
            }
            else
            {
                _posts = new List<Post>();
                SaveToFile();
            }
        }

       
        public List<Post> GetAll()
        {
            lock (_lock)
            {
               if (_posts == null)
                {
                    return new List<Post>();
                }
               return _posts
                    .OrderByDescending(p => p.CreatedUtc)
                    .ToList();
            }
        }

        
        public Post? GetById(int id)
        {
            lock (_lock)
            {
                return _posts.FirstOrDefault(p => p.Id == id);
            }
        }

        
        public void Add(Post post)
        {
            lock (_lock)
            {
                post.Id = _posts.Count == 0
                    ? 1
                    : _posts.Max(p => p.Id) + 1;

              
                post.CreatedUtc = DateTime.UtcNow;

                
                _posts.Add(post);

                SaveToFile();
            }
        }

        private void SaveToFile()
        {
            string json = JsonSerializer.Serialize(
                _posts,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(_filePath, json);
        }
    }
}