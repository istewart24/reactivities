using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BaseApiController : ControllerBase
{
    private IMediator _mediator;
    
    // get IMediator service if not already setup
    protected IMediator Mediator => _mediator ??= 
        HttpContext.RequestServices.GetService<IMediator>();
}