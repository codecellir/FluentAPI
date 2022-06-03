using FluentAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentAPI.Mapping
{
    public class CourseMap : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.PreCourseId)
                .IsRequired(false);

            builder.HasOne(x => x.PreCourse)
                .WithMany()
                .HasForeignKey(x => x.PreCourseId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
