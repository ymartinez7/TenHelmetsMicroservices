namespace TenHelmets.MS.Infrastructure.Data.Config
{
    using TenHelmets.MS.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// 
    /// </summary>
    public sealed class SaleDetailConfig : IEntityTypeConfiguration<SaleDetail>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<SaleDetail> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Quantity).IsRequired();
            builder.Property(p => p.UnitPrice).IsRequired();

            builder.HasOne(p => p.Sale).WithMany().HasForeignKey(p => p.SaleId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Resource).WithMany().HasForeignKey(p => p.ResourceId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Model).WithMany().HasForeignKey(p => p.ModelId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
