

using Microsoft.EntityFrameworkCore;

public class DataAccessSQL : DbContext
{
    public DbSet<UserModelSQL> Users { get; set; }
    public DataAccessSQL(string connString) : base(GetOptions(connString))
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserModelSQL>().ToTable("User");
    }

    private static DbContextOptions GetOptions(string connectionString)
    {
        return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
    }
}