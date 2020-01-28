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
                entity.Property(e => e.user_id)
                    .HasColumnName("user_id");

                entity.Property(e => e.client_id)
                    .HasColumnName("client_id");

                entity.Property(e => e.firstname)
                  .HasColumnName("firstname");

                entity.Property(e => e.lastname)
                  .HasColumnName("lastname");

                entity.Property(e => e.nickname)
                  .HasColumnName("nickname");

                entity.Property(e => e.email)
                  .HasColumnName("email");

                entity.Property(e => e.organisational_unit)
                  .HasColumnName("organisational_unit");

                entity.Property(e => e.job_title)
                  .HasColumnName("job_title");

                entity.Property(e => e.target_allocation)
                  .HasColumnName("target_allocation");

                entity.Property(e => e.status)
                 .HasColumnName("status");

                entity.Property(e => e.hire_date)
                 .HasColumnName("hire_date");



            });
            
        }

    }
    

}