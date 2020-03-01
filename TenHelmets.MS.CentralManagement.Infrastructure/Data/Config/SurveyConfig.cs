namespace TenHelmets.MS.Infrastructure.Data.Config
{
    using TenHelmets.MS.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// 
    /// </summary>
    public sealed class SurveyConfig : IEntityTypeConfiguration<Survey>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Survey> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Score).IsRequired();
            builder.Property(p => p.Qualification).IsRequired().HasMaxLength(200);

            builder.HasOne(p => p.Customer).WithMany().HasForeignKey(p => p.CustomerId).OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(p => p.Project).WithMany().HasForeignKey(p => p.ProjectId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
