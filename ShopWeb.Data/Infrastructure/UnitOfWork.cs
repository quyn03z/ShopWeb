using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Data.Infrastructure
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly IDbFactory dbFactory;
		private ShopWebDbContext dbContext;

		public UnitOfWork(IDbFactory dbFactory)
		{
			this.dbFactory = dbFactory;
		}

		public ShopWebDbContext DbContext()
		{
			return dbContext ?? (dbContext = new ShopWebDbContext());
		}

		public void Commit()
		{
			dbContext.SaveChanges();
		}
	}
}
