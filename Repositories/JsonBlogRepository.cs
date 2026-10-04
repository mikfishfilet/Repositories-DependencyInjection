using System.Text.Json;
using MicroBlog.Models;

namespace MicroBlog.Repositories;

public class JsonBlogRepository : IBlogRepository
{
    private readonly string _filePath;
    private readonly List<Post> _posts;

    public JsonBlogRepository(IWebHostEnvironment environment)
    {
        _filePath = Path.Combine(
            environment.ContentRootPath,
            "data",
            "posts.json"
            );

        if (File.Exists(_filePath))
        {
            var json = File.ReadAllText(_filePath);

            _posts = JsonSerializer.Deserialize<List<Post>>(json)
                ?? new List<Post>();
        }
        else
        {
            _posts = new List<Post>();
        }
    }

    public IEnumerable<Post> GetAll()
    {
        return _posts;
    }

    public Post GetById(int id)
    {
        return _posts.FirstOrDefault(p => p.Id == id);
    }

    public void Add(Post post)
    {
        _posts.Add(post);
    }

    public void Save()
    {
        Directory.CreateDirectory(Path.GetDirectoryName(_filePath)!);

        var json = JsonSerializer.Serialize( 
            _posts,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });

        File.WriteAllText(_filePath, json);
    }
}