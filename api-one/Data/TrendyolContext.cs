namespace api_one.Data
{
 public class TrendyolContext : DbContext
{
    public TrendyolContext()
    {
  
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
         optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
    //entities
    public DbSet<InventoryItem> InventoryItem { get; set; }
} 
}