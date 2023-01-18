using Api.Data.Models;
using MediatR;

namespace Api.Functions.Query;

public enum OrderByPostOptions
{
    None = 0,
    ByTitle = 1,
    ByDate = 2,
    ByAuthor = 3
}

public class GetAllPostQuery : IRequest<List<Post>>
{
    public OrderByPostOptions OrderBy { get; set; }
}
