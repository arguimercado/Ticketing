using Api.Commons.Base;
using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Applications.Features.Tickets.Commands.CreateTickets;

public class CreateTicketApi : BaseModule
{
    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/ticket/create", async (ISender sender, [FromBody] CreateTicketCommand cmd) =>
        {
            var result = await sender.Send(cmd);
            return HandleRequest(result);
        });
    }
}