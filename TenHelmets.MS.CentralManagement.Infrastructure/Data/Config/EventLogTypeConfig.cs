﻿using TenHelmets.MS.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TenHelmets.MS.Infrastructure.Data.Config
{
    public sealed class EventLogTypeConfig : IEntityTypeConfiguration<EventLogType>
    {
        public void Configure(EntityTypeBuilder<EventLogType> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired();
        }
    }
}
