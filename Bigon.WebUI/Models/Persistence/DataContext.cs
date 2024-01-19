using System;
using Bigon.WebUI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bigon.WebUI.Models.Persistence
{
	public class DataContext:DbContext
	{
		public DataContext(DbContextOptions options)
			:base(options)
		{
		}

		public DbSet<Size> Sizes { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<Material> Materials { get; set; }

        public DbSet<Brand> Brands { get; set; }
    }
}

