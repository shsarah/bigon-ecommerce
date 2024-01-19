using System;
using Bigon.WebUI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bigon.WebUI.Models.Persistence.Configurations
{
	public class SizeEntityConfiguration:IEntityTypeConfiguration<Size>
	{
        public void Configure(EntityTypeBuilder<Size> builder)
        {

            builder.Property(m => m.Name).IsRequired().HasColumnType("nvarchar").HasMaxLength(100);

            builder.HasKey(m=>m.Id);
            builder.ToTable("Sizes");
        }
    }
}

