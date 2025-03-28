using MediatR;
using Microsoft.AspNetCore.Mvc;
using PortalManagement.Application.Features.MediatR.Authentication.CreateUser.Commands;
using PortalManagement.DTO.DTOS.UserDtos;

namespace PortalManagement.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationsController : ControllerBase
{
    private readonly IMediator _mediator;

    public AuthenticationsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("CreateUser")]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserDto createUserDto)
    {
        var command = new CreateUserCommand(createUserDto);
        await _mediator.Send(command);
        return Ok(new { message = "User created successfully." });
    }
}
