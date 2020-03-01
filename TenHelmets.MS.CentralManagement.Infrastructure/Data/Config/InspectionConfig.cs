namespace TenHelmets.MS.Infrastructure.Data.Config
{
    using TenHelmets.MS.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// 
    /// </summary>
    public sealed class InspectionConfig : IEntityTypeConfiguration<Inspection>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Inspection> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Date).IsRequired();

            builder.HasOne(p => p.Activity).WithMany().HasForeignKey(p => p.ActivityId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.InspectionType).WithMany().HasForeignKey(p => p.InspectionTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
