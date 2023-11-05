using System;
using BulkyBook2.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook2.Data
{
	public class ApplicationDbContext: DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{

		}
		public DbSet<Category> Categories { get; set; }
	}
}

