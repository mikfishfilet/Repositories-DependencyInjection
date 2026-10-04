using MicroBlog.Models;

namespace MicroBlog.Repositories;

public class InMemoryBlogRepository : IBlogRepository
{

    private readonly List<Post> _posts = new();

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

    }

} 
