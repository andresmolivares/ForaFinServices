namespace ForaFinServices.DataModel;

using Microsoft.EntityFrameworkCore;

public class ForaFinDbContext : DbContext
{
    public DbSet<CikItem> CikItems { get; set; } = null!;

    public ForaFinDbContext(DbContextOptions<ForaFinDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CikItem>()
            .HasKey(x => x.Key);

        modelBuilder.Entity<CikItem>()
            .HasIndex(x => x.Key)
            .IsUnique();
    }
}

