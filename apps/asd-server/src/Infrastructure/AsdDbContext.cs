using Asd.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Asd.Infrastructure;

public class AsdDbContext : DbContext
{
    public AsdDbContext(DbContextOptions<AsdDbContext> options)
        : base(options) { }

    public DbSet<TestDbModel> Tests { get; set; }
}
