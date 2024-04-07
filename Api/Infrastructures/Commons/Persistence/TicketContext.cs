using Api.Models;
using Api.Models.Tickets;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructures.Commons.Persistence;

public class TicketContext(DbContextOptions<TicketContext> options) : IdentityDbContext<User>(options)
{
    public DbSet<Ticket> Tickets { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}