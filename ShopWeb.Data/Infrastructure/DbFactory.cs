using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Data.Infrastructure
{
	public class DbFactory : Disposable, IDbFactory
	{
		ShopWebDbContext dbContext;
		public ShopWebDbContext Init()
		{
			return dbContext ?? (dbContext = new ShopWebDbContext());
		}
		protected override void DisposeCore()
		{
			if(dbContext != null) dbContext.Dispose();
		}
	}
}
