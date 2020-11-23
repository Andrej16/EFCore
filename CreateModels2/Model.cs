using Microsoft.EntityFrameworkCore;

namespace CreateModels2
{
    public class Model : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=CustomDb.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
        }
    }
}
