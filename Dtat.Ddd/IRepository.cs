namespace Dtat.Ddd
{
	public interface IRepository<T> : IQueryRepository<T> where T : IAggregateRoot
	{
		System.Threading.Tasks.Task AddAsync
			(T entity, System.Threading.CancellationToken cancellationToken = default);

		System.Threading.Tasks.Task AddRangeAsync
			(System.Collections.Generic.IList<IAggregateRoot>
			entities, System.Threading.CancellationToken cancellationToken = default);

		System.Threading.Tasks.Task UpdateAsync
			(T entity, System.Threading.CancellationToken cancellationToken = default);

		System.Threading.Tasks.Task RemoveAsync
			(T entity, System.Threading.CancellationToken cancellationToken = default);

		System.Threading.Tasks.Task<bool> RemoveByIdAsync
			(System.Guid id, System.Threading.CancellationToken cancellationToken = default);
	}
}
