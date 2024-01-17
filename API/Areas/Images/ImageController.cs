using API.Common.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using GetImages = Core.Features.Image.Queries.GetImages;

namespace API.Areas.Images;

[Route("images")]
public class ImageController : Controller
{
    private readonly IMediator _mediator;

    public ImageController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [Route("")]
    public async Task<IActionResult> GetImages(GetImages.Query query)
    {
        var response = await _mediator.Send(query);

        return response.Match<IActionResult>(
            ok => Json(ok),
            err => BadRequest(new ErrorModel(err.Message))
        );
    }
}