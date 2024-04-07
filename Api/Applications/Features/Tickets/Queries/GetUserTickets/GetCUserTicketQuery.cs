using MediatR;

namespace Api.Applications.Features.Tickets.Queries.GetUserTickets
{
    public class UserTicketResponse
    {
        public int TicketNo { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }

        public int Severity { get; set; } 
        public string Category { get; set; } = null!;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? SubmittedDate { get; private set; }
        public string Status { get; private set; } = "";

    }
    public record GetUserTicketQuery : IRequest<IEnumerable<UserTicketResponse>>;
}
