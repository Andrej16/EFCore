using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace QueriesToOracle
{
    public class Context : DbContext
    {
        public DbSet<IdentRisk> IdentRisks { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<TKeyValue> KeyValues { get; set; }
        public DbSet<IdentData> IdentDatas { get; set; }
        public IQueryable<IdentData> GetFromTable(DateTime date)
        {
            return null;//FromExpression(() => GetFromTable(date));
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(@"Data Source=dboracledev.ingo.office:1521/insbcp;Persist Security Info=True;User ID=INSURADM;Password=AisIngo");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "INSURADM");
            //modelBuilder.HasDbFunction(() => GetFromTable(default));
            modelBuilder.ApplyConfiguration(new IdentRiskConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new TKeyValueConfiguration());
            modelBuilder.ApplyConfiguration(new IdentDataConfiguration());
        }
    }
    public class IdentData
    {
        public int? Id { get; set; }
        public int? SubjectId { get; set; }
        public string SubjectName { get; set; }
        public DateTime? DateBirth { get; set; }
        public string Inn { get; set; }
        public DateTime? DateIdentStart { get; set; }
        public DateTime? DateIdentEnd { get; set; }
    }

    public class TKeyValue
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
    public class IdentRisk
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public partial class Subject
    {
        public Subject()
        {
            //InverseSubDe = new HashSet<Subject>();
            //InverseSubParent = new HashSet<Subject>();
            //InverseSubUpdatedby = new HashSet<Subject>();
        }
        public decimal SubId { get; set; }
        public decimal? SubStId { get; set; }
        public decimal? SubCntId { get; set; }
        public string SubNameshort { get; set; }
        public string SubNamefull { get; set; }
        public string SubNamefulllat { get; set; }
        public string SubNameprint { get; set; }
        public string SubInn { get; set; }
        public string SubReg { get; set; }
        public string SubRemark { get; set; }
        public string SubActive { get; set; }
        public DateTime? SubUpdated { get; set; }
        public decimal? SubUpdatedbyId { get; set; }
        public decimal? SubAccentId { get; set; }
        public decimal? SubParentId { get; set; }
        public decimal? SubDtfId { get; set; }
        public decimal? SubDeId { get; set; }
        public decimal? SubCheckfm { get; set; }
        public string SubPortalId { get; set; }
        public decimal? Kvedactivitytypeid { get; set; }
        public string Position { get; set; }
        public string Ismembnatminority { get; set; }
        public decimal? Citizencountryid { get; set; }

        //public virtual Subject SubDe { get; set; }
        //public virtual Subject SubParent { get; set; }
        //public virtual Subject SubUpdatedby { get; set; }
        //public virtual ICollection<Subject> InverseSubDe { get; set; }
        //public virtual ICollection<Subject> InverseSubParent { get; set; }
        //public virtual ICollection<Subject> InverseSubUpdatedby { get; set; }
    }
}
