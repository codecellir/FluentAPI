using FluentAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentAPI.Mapping
{
    public class GradeMap : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.ToTable("StudentGrade");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(10)
                .IsRequired();
        }
    }
}
