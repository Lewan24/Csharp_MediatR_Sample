using Microsoft.Extensions.Hosting;

namespace Api.Data.Models;

public class Category
{
    public int CategoryId { get; set; }

    public string Name { get; set; }

    public string DisplayName { get; set; }

    public ICollection<Post> Posts { get; set; }
}