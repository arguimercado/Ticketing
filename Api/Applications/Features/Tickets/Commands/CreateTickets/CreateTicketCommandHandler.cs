
using Api.Infrastructures.Commons.Persistence;
using Api.Models.Tickets;
using FluentResults;
using MediatR;

namespace Api.Applications.Features.Tickets.Commands.CreateTickets;

internal class CreateTicketCommandHandler(TicketContext ticketContext) : IRequestHandler<CreateTicketCommand, Result<CreateTicketResponse>>
{
    private readonly TicketContext _ticketContext = ticketContext;

    public async Task<Result<CreateTicketResponse>> Handle(CreateTicketCommand request, CancellationToken cancellationToken)
    {

        var ticket = new Ticket(
            request.Title,
            request.Description,
            request.Company,
            request.Branch,
            request.Department, request.Severity,
            request.Category,
            request.AssignedTo);

        _ticketContext.Add(ticket);
        
        await _ticketContext.SaveChangesAsync();

        return Result.Ok(new CreateTicketResponse { TicketNo = ticket.TicketNo });
    }
}