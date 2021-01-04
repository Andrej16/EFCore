using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QueriesToOracle
{
    public class IdentRiskConfiguration : IEntityTypeConfiguration<IdentRisk>
    {
        public void Configure(EntityTypeBuilder<IdentRisk> builder)
        {
            builder.ToTable("IDENTRISK");
            builder.Property(p => p.Id)
                .HasColumnName("ID");
            builder.Property(p => p.Name)
                .HasColumnName("NAME");
        }
    }
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable("SUBJECT");
            builder.HasKey(e => e.SubId)
                .HasName("X_SUBJECT");            

            builder.HasIndex(e => e.SubAccentId)
                .HasName("U_SUBJECT_SUB_ACCENT_ID")
                .IsUnique();

            builder.HasIndex(e => e.SubInn)
                .HasName("SUBJECT_I1_SUB_INN");

            builder.HasIndex(e => e.SubReg)
                .HasName("SUBJECT_I1_SUB_REG");

            builder.Property(e => e.SubId)
                .HasColumnName("SUB_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Citizencountryid)
                .HasColumnName("CITIZENCOUNTRYID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Ismembnatminority)
                .HasColumnName("ISMEMBNATMINORITY")
                .HasColumnType("CHAR(1)")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Kvedactivitytypeid)
                .HasColumnName("KVEDACTIVITYTYPEID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Position)
                .HasColumnName("POSITION")
                .HasMaxLength(300)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.SubAccentId)
                .HasColumnName("SUB_ACCENT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.SubActive)
                .HasColumnName("SUB_ACTIVE")
                .HasColumnType("CHAR(1)")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.SubCheckfm)
                .HasColumnName("SUB_CHECKFM")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.SubCntId)
                .HasColumnName("SUB_CNT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.SubDeId)
                .HasColumnName("SUB_DE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.SubDtfId)
                .HasColumnName("SUB_DTF_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.SubInn)
                .HasColumnName("SUB_INN")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.SubNamefull)
                .HasColumnName("SUB_NAMEFULL")
                .HasMaxLength(400)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.SubNamefulllat)
                .HasColumnName("SUB_NAMEFULLLAT")
                .HasMaxLength(400)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.SubNameprint)
                .HasColumnName("SUB_NAMEPRINT")
                .HasMaxLength(400)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.SubNameshort)
                .HasColumnName("SUB_NAMESHORT")
                .HasMaxLength(255)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.SubParentId)
                .HasColumnName("SUB_PARENT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.SubPortalId)
                .HasColumnName("SUB_PORTAL_ID")
                .HasMaxLength(60)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.SubReg)
                .HasColumnName("SUB_REG")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.SubRemark)
                .HasColumnName("SUB_REMARK")
                .HasMaxLength(500)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.SubStId)
                .HasColumnName("SUB_ST_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.SubUpdated)
                .HasColumnName("SUB_UPDATED")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.SubUpdatedbyId)
                .HasColumnName("SUB_UPDATEDBY_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        }
    }
}
