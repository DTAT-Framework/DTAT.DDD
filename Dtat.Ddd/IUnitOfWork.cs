﻿namespace Dtat.Ddd
{
	public interface IUnitOfWork : IQueryUnitOfWork
	{
		System.Threading.Tasks.Task SaveAsync();
	}
}
