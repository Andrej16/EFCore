using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManyToMany
{
    public class Context : DbContext
    {
        public DbSet<IdentData> IdentDatas { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        //public DbSet<IdentDataSubject> IdentDataSubjects { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=relationsdb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new IdentDataSubjectConfiguration());
        }
    }
}
