namespace _10Helmets.API.Infrastructure.Data.Config
{
    using _10Helmets.API.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// 
    /// </summary>
    public sealed class AlertTypeConfig : IEntityTypeConfiguration<AlertType>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<AlertType> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(200);
        }
    }
}
