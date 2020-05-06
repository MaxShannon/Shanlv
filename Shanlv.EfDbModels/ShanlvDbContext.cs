using Microsoft.EntityFrameworkCore;
using Shanlv.EfDbModels.DbTable;

namespace Shanlv.EfDbModels
{
    public class ShanlvDbContext : DbContext
    {
        public ShanlvDbContext() //: base("con")
        {
            //Database.SetInitializer<BlogContext>(null);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=.;database=BlogSystem;uid=sa;pwd=sa";
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
        //public DbSet<Article> Articles { get; set; }
        //public DbSet<ArticleToCategory> ArticleToCategories { get; set; }
        //public DbSet<Comment> Comments { get; set; }
        //public DbSet<Fans> Fans { get; set; }
    }
}
