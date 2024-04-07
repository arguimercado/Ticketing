using Api.Models.Tickets;
using FluentResults;
using MediatR;

namespace Api.Applications.Features.Tickets.Commands.CreateTickets;

public record CreateTicketCommand(
    string Title,
    string? Description,
    SeverityEnum Severity,
    string Category,
    string Company,
    string Branch,
    string Department,
    string? AssignedTo) : IRequest<Result<CreateTicketResponse>>;
public class CreateTicketResponse
{
    public int TicketNo { get; set; }
}