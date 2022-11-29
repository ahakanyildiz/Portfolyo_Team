using Microsoft.EntityFrameworkCore;
using Portfolyo.Entites;

namespace Portfolyo.Data
{
    public class MsSqlContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-UIFM5O9\SQLEXPRESS;Database=Portfolio_Db;Trusted_Connection=True;");
        }

        //Fluent Api ile de prop'larımızın özelliklerini güncelleyebilir, değiştirebiliriz.
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            //modelBuilder.Entity<About>().Property(x => x.Graduation).HasMaxLength(50);
		}

		public DbSet<About> Abouts { get; set; }
        public DbSet<Fact> Facts { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}
