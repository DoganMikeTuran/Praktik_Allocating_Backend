using System;
using Microsoft.EntityFrameworkCore;

namespace Backend_4.Model
{
    public class DB_context : DbContext
    {
        public DB_context()
        {
        }

        public DB_context(DbContextOptions<DB_context> options) : base(options) { }

        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.id)
                    .HasColumnName("id");

                entity.Property(e => e.email)
                    .HasColumnName("email");

                entity.Property(e => e.password)
                  .HasColumnName("password");

                entity.Property(e => e.firstname)
                  .HasColumnName("firstname");

                entity.Property(e => e.lastname)
                  .HasColumnName("lastname");
            });
            
        }

    }
    

}