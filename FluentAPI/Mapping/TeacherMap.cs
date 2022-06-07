using FluentAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentAPI.Mapping
{
    public class TeacherMap : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("Teacher");

            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x=>x.Family)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x=>x.Code)
                .HasMaxLength(10)
                .IsRequired();

            builder.HasData(new Teacher
            {
                Id = 1,
                Code="1",
                Name="T1",
                Family="F1"
            },
            new Teacher
            {
                Id = 2,
                Code = "2",
                Name = "T2",
                Family = "F2"
            },
            new Teacher
            {
                Id = 3,
                Code = "3",
                Name = "T3",
                Family = "F3"
            });
        }
    }
}
