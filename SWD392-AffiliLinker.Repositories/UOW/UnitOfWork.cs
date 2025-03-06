﻿using SWD392_AffiliLinker.Repositories.Context;
using SWD392_AffiliLinker.Repositories.Interfaces;
using SWD392_AffiliLinker.Repositories.IUOW;
using SWD392_AffiliLinker.Repositories.Repositories;

namespace SWD392_AffiliLinker.Repositories.UOW
{
    public class UnitOfWork(DatabaseContext dbContext) : IUnitOfWork
	{
		private bool disposed = false;
		private readonly DatabaseContext _dbContext = dbContext;
		public void BeginTransaction()
		{
			_dbContext.Database.BeginTransaction();
		}

		public void CommitTransaction()
		{
			_dbContext.Database.CommitTransaction();
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		protected virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
					_dbContext.Dispose();
				}
			}
			disposed = true;
		}

		public void RollBack()
		{
			_dbContext.Database.RollbackTransaction();
		}

		public void Save()
		{
			_dbContext.SaveChanges();
		}

		public async Task SaveAsync()
		{
			await _dbContext.SaveChangesAsync();
		}

		public IGenericRepository<T> GetRepository<T>() where T : class
		{
			return new GenericRepository<T>(_dbContext);
		}
	}
}
