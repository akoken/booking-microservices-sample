namespace Identity.Identity.Features.RegisteringNewUser.V1;

using System.Threading;
using System.Threading.Tasks;
using BuildingBlocks.Web;
using Hellang.Middleware.ProblemDetails;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Swashbuckle.AspNetCore.Annotations;

public record RegisterNewUserRequestDto(string FirstName, string LastName, string Username, string Email,
    string Password, string ConfirmPassword, string PassportNumber);

public record RegisterNewUserResponseDto(long Id, string FirstName, string LastName, string Username, string PassportNumber);

public class RegisterNewUserEndpoint : IMinimalEndpoint
{
    public IEndpointRouteBuilder MapEndpoint(IEndpointRouteBuilder builder)
    {
        builder.MapPost($"{EndpointConfig.BaseApiPath}/identity/register-user", RegisterNewUser)
            .WithTags("Identity")
            .WithName("RegisterUser")
            .WithMetadata(new SwaggerOperationAttribute("Register User", "Register User"))
            .WithApiVersionSet(builder.NewApiVersionSet("Identity").Build())
            .WithMetadata(
                new SwaggerResponseAttribute(
                    StatusCodes.Status200OK,
                    "User Registered",
                    typeof(RegisterNewUserResponseDto)))
            .WithMetadata(
                new SwaggerResponseAttribute(
                    StatusCodes.Status400BadRequest,
                    "BadRequest",
                    typeof(StatusCodeProblemDetails)))
            .HasApiVersion(1.0);

        return builder;
    }

    private async Task<IResult> RegisterNewUser(RegisterNewUserRequestDto request, IMediator mediator, IMapper mapper,
        CancellationToken cancellationToken)
    {
        var command = mapper.Map<RegisterNewUser>(request);

        var result = await mediator.Send(command, cancellationToken);

        var response = mapper.Map<RegisterNewUserResponseDto>(result);

        return Results.Ok(response);
    }
}
