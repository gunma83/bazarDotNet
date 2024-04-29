using System;
using Microsoft.EntityFrameworkCore;

namespace webapi.Models
{
	public class BazarContext : DbContext
	{
		public DbSet<Category> Categories { get; set; }

		public BazarContext(DbContextOptions options) : base(options)
		{

		}
	}
}

