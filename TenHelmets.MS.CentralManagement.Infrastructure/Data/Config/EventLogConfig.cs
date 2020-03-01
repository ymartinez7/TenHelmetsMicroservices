namespace TenHelmets.MS.Infrastructure.Data.Config
{
    using TenHelmets.MS.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// 
    /// </summary>
    public sealed class EventLogConfig : IEntityTypeConfiguration<EventLog>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<EventLog> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Description).IsRequired().HasMaxLength(500);

            builder.HasOne(p => p.EventLogType).WithMany().HasForeignKey(p => p.EventLogTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
