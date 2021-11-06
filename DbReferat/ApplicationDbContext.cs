using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Tests.Models;

namespace Tests
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(string connection) : base(connection){}
        
        public DbSet<Author> Authors { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<TitleAuthor> TitleAuthors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sale>().HasKey(s => new { s.TitleId, s.StoreId, s.OrderNumber });
            modelBuilder.Entity<TitleAuthor>().HasKey(t => new { t.AuthorId, t.TitleId });
            base.OnModelCreating(modelBuilder);
        }
    }
}