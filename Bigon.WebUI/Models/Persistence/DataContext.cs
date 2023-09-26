using System;
using Microsoft.EntityFrameworkCore;

namespace Bigon.WebUI.Models.Persistence
{
	public class DataContext:DbContext
	{
		public DataContext(DbContextOptions options)
			:base(options)
		{
		}
	}
}

