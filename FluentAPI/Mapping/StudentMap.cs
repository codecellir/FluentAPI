using FluentAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentAPI.Mapping
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("STD");

            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Id)
                .ValueGeneratedNever();

            builder.HasIndex(x => x.NationalCode);

            builder.HasIndex(x => x.NationalCode).IsUnique();

            builder.HasIndex(x => new { x.Age, x.NationalCode });

            builder.Property(x => x.Name)
                .IsRequired();

            builder.Property(x => x.Family)
                .IsRequired(false);

            builder.Property(x => x.Family)
                .HasColumnName("LastName");

            builder.Property(x => x.DisplayName)
                .HasComputedColumnSql("[Name]+' '+[LastName]");

            builder.Property(x => x.Age)
                .HasDefaultValue(10);

            builder.Property(x => x.Age)
                .HasColumnType("tinyint");

            builder.Property(x => x.Score)
                .HasColumnType("float");

            builder.HasQueryFilter(x => x.Active);

            builder.Ignore(x => x.CourseName);
        }
    }
}
