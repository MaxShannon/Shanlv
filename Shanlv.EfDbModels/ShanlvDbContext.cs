using Microsoft.EntityFrameworkCore;
using Shanlv.DomainModel;

namespace Shanlv.EfDbModels
{
    public class ShanlvDbContext : DbContext
    {
        public ShanlvDbContext(DbContextOptions<ShanlvDbContext> options) : base(options)
        {
            //Database.SetInitializer<BlogContext>(null);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=10.28.7.12;database=Shanlv;uid=sa;pwd=Admin123456";
            optionsBuilder.UseSqlServer(connectionString);
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        //    modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        //}


        //public DbSet<User> Users { get; set; }


        public DbSet<User> Users { get; set; }
        public DbSet<Cargo> Cargoes { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        //public DbSet<Article> Articles { get; set; }
        //public DbSet<ArticleToCategory> ArticleToCategories { get; set; }
        //public DbSet<Comment> Comments { get; set; }
        //public DbSet<Fans> Fans { get; set; }
    }
}
