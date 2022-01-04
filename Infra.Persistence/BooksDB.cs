namespace APIDemo.Infra.Persistence
{
    public class BooksDB : DbContext
    {
        public BooksDB(DbContextOptions<BooksDB> options) : base(options) { }
        public DbSet<Book> Books => Set<Book>();
    }
}