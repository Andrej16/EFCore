using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManyToMany
{
    public class IdentDataSubjectConfiguration : IEntityTypeConfiguration<IdentDataSubject>
    {
        public void Configure(EntityTypeBuilder<IdentDataSubject> builder)
        {
            builder
                .HasKey(ids => new { ids.SubjectId, ids.IdentDataId });
            builder
                .HasOne(ids => ids.Subject)
                .WithMany(s => s.IdentDataSubjects)
                .HasForeignKey(ids => ids.SubjectId);
            builder
                .HasOne(ids => ids.Ident)
                .WithMany(i => i.IdentDataSubjects)
                .HasForeignKey(ids => ids.IdentDataId);                
        }
    }

}
