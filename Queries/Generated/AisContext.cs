/*using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QueriesToOracle
{
    public partial class AisContext : DbContext
    {
        public AisContext()
        {
        }

        public AisContext(DbContextOptions<AisContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Subject> Subject { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseOracle("Data Source=dboracledev.ingo.office:1521/insbcp;Persist Security Info=True;User ID=INSURADM;Password=AisIngo");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "INSURADM");

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasKey(e => e.SubId)
                    .HasName("X_SUBJECT");

                entity.ToTable("SUBJECT");

                entity.HasIndex(e => e.SubAccentId)
                    .HasName("U_SUBJECT_SUB_ACCENT_ID")
                    .IsUnique();

                entity.HasIndex(e => e.SubInn)
                    .HasName("SUBJECT_I1_SUB_INN");

                entity.HasIndex(e => e.SubReg)
                    .HasName("SUBJECT_I1_SUB_REG");

                entity.Property(e => e.SubId)
                    .HasColumnName("SUB_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Citizencountryid)
                    .HasColumnName("CITIZENCOUNTRYID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ismembnatminority)
                    .HasColumnName("ISMEMBNATMINORITY")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Kvedactivitytypeid)
                    .HasColumnName("KVEDACTIVITYTYPEID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Position)
                    .HasColumnName("POSITION")
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubAccentId)
                    .HasColumnName("SUB_ACCENT_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubActive)
                    .HasColumnName("SUB_ACTIVE")
                    .HasColumnType("CHAR(1)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubCheckfm)
                    .HasColumnName("SUB_CHECKFM")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubCntId)
                    .HasColumnName("SUB_CNT_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubDeId)
                    .HasColumnName("SUB_DE_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubDtfId)
                    .HasColumnName("SUB_DTF_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubInn)
                    .HasColumnName("SUB_INN")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubNamefull)
                    .HasColumnName("SUB_NAMEFULL")
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubNamefulllat)
                    .HasColumnName("SUB_NAMEFULLLAT")
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubNameprint)
                    .HasColumnName("SUB_NAMEPRINT")
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubNameshort)
                    .HasColumnName("SUB_NAMESHORT")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubParentId)
                    .HasColumnName("SUB_PARENT_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubPortalId)
                    .HasColumnName("SUB_PORTAL_ID")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubReg)
                    .HasColumnName("SUB_REG")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubRemark)
                    .HasColumnName("SUB_REMARK")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubStId)
                    .HasColumnName("SUB_ST_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubUpdated)
                    .HasColumnName("SUB_UPDATED")
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubUpdatedbyId)
                    .HasColumnName("SUB_UPDATEDBY_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.SubDe)
                    .WithMany(p => p.InverseSubDe)
                    .HasForeignKey(d => d.SubDeId)
                    .HasConstraintName("F_SUBJECT_SUB_DE_ID");

                entity.HasOne(d => d.SubParent)
                    .WithMany(p => p.InverseSubParent)
                    .HasForeignKey(d => d.SubParentId)
                    .HasConstraintName("F_SUBJECT_SUB_PARENT_ID");

                entity.HasOne(d => d.SubUpdatedby)
                    .WithMany(p => p.InverseSubUpdatedby)
                    .HasForeignKey(d => d.SubUpdatedbyId)
                    .HasConstraintName("F_SUBJECT_SUB_UPDATEDBY_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}*/
