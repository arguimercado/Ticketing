using Api.Models.Tickets.ValueObjects;

namespace Api.Models.Tickets;

public enum SeverityEnum
{
    NotUrgent = 0,
    Urgent = 1
}

public enum TicketStatusEnum
{
    Draft = 1,
    Pending = 2,
    Assigned = 3,
    Grabbed = 4,
    Resolved = 5,
    Close = 6
}
public class Ticket
{
    private Ticket()
    {

    }
    public Ticket(string title,
                  string? description,
                  string company,
                  string branch,
                  string department,
                  SeverityEnum severity,
                  string category,
                  string? assignedTo = null)
    {

        Title = title;
        Description = description;
        DateCreated = DateTime.Now;
        Status = TicketStatusEnum.Draft.ToString();
        Company = company;
        Branch = branch;
        Department = department;
        Severity = severity;
        Category = category;
        AssignedTo = assignedTo;
        IsActive = true;
    }

    public int TicketNo { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public string Company { get; set; } = null!;
    public string Branch { get; set; } = null!;
    public string Department { get; set; } = null!;
    public SeverityEnum Severity { get; set; } = SeverityEnum.NotUrgent;
    public string Category { get; set; } = null!;
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime? SubmittedDate { get; private set; }
    public string Status { get; private set; } = TicketStatusEnum.Draft.ToString();
    public bool IsActive { get; private set; } = true;
    public string? AssignedTo { get; set; }
    public TicketProgress Progress { get; set; } = TicketProgress.SetProgress(0);

    public void ChangeStatus(TicketStatusEnum ticket)
    {

        Status = ticket.ToString();
    }
    public void Submit()
    {
        Status = TicketStatusEnum.Pending.ToString();
        SubmittedDate = DateTime.Now;
    }



}