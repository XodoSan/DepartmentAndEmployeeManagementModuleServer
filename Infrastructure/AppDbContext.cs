using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasOne(x => x.Subdivision)
                .WithMany(x => x.Persons)
                .HasForeignKey(x => x.SubdivisionId);
        }
    }
}