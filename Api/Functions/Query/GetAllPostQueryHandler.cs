using MediatR;
using Api.Data.Models;

namespace Api.Functions.Query;

public class GetAllPostQueryHandler : IRequestHandler<GetAllPostQuery, List<Post>>
{
    public Task<List<Post>> Handle(GetAllPostQuery request, CancellationToken cancellationToken)
    {
        var posts = DummyPosts.Get();

        if (request.OrderBy == OrderByPostOptions.ByAuthor)
            return Task.FromResult(posts.OrderBy(p => p.Author).ToList());

        if (request.OrderBy == OrderByPostOptions.ByDate)
            return Task.FromResult(posts.OrderBy(p => p.Date).ToList());

        if (request.OrderBy == OrderByPostOptions.ByTitle)
            return Task.FromResult(posts.OrderBy(p => p.Title).ToList());

        return Task.FromResult(posts);
    }
}
