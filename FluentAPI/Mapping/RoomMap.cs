using FluentAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentAPI.Mapping
{
    public class RoomMap : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("Room");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.CategoryCode)
                .IsRequired()
                .HasMaxLength(20);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Rooms)
                .HasForeignKey(x => x.CategoryCode)
                .HasPrincipalKey(c => c.Code);
        }
    }
}
