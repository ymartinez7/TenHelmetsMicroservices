using TenHelmets.MS.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TenHelmets.MS.Infrastructure.Data.Config
{
    public sealed class EventLogConfig : IEntityTypeConfiguration<EventLog>
    {
        public void Configure(EntityTypeBuilder<EventLog> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Description).IsRequired().HasMaxLength(500);

            builder.HasOne(p => p.EventLogType).WithMany().HasForeignKey(p => p.EventLogTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
