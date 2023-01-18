using Api.Data.Models;
using Api.Functions.Command;
using Api.Functions.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PostController : ControllerBase
{
    private readonly IMediator _mediator;

    public PostController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // GET: api/<PostController>
    [HttpGet(Name = "GetAllPosts"), ActionName(nameof(GetAllPosts))]
    public async Task<ActionResult<List<Post>>> GetAllPosts()
    {
        var request = new GetAllPostQuery { OrderBy = OrderByPostOptions.ByDate };

        var result = await _mediator.Send(request);

        return result;
    }

    [HttpPut(Name = "UpdatePost"), ActionName(nameof(UpdatePost))]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> UpdatePost([FromBody] UpdatePostCommand updatePostCommand)
    {
        await _mediator.Send(updatePostCommand);

        return NoContent();
    }
}
