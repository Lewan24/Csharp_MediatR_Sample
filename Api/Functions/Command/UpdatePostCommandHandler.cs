using MediatR;
using Api.Data.Models;

namespace Api.Functions.Command;

public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand, Unit>
{
    public Task<Unit> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
    {
        Post p = new Post() 
        { 
            Author = request.Author,
            Category = request.Category,
            CategoryId = request.CategoryId,
            Date = request.Date,
            Description = request.Description,
            ImageUrl = request.ImageUrl,
            PostId = request.PostId,
            Rate = request.Rate,
            Title = request.Title,
            Url = request.Url
        };

        return Task.FromResult(Unit.Value);
    }
}
