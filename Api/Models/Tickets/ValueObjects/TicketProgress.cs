namespace Api.Models.Tickets.ValueObjects;

public class TicketProgress
{
    public TicketProgress() {}
    public TicketProgress(int progress, DateTime? dateCompleted =null)
    {
        Progress = progress;
        DateCompleted = dateCompleted;
    }

    public int Progress { get; private set; }
    public DateTime? DateCompleted { get; private set; }
    
    public static  TicketProgress SetProgress(int progress) {
        DateTime? completed = null;
        if(progress < 0 || progress > 100)
            throw new Exception("Progress can be only set to 0 - 100");
        if(progress == 100)
            completed = DateTime.Now;

        return new TicketProgress(progress,completed);

    }

}