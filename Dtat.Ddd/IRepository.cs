namespace Dtat.Ddd
{
	public interface IRepository<T> where T : IAggregateRoot
	{
		System.Threading.Tasks.Task AddAsync
			(T entity, System.Threading.CancellationToken cancellationToken = default);

		System.Threading.Tasks.Task AddRangeAsync
			(System.Collections.Generic.IEnumerable<T>
			entities, System.Threading.CancellationToken cancellationToken = default);

		System.Threading.Tasks.Task UpdateAsync
			(T entity, System.Threading.CancellationToken cancellationToken = default);

		System.Threading.Tasks.Task RemoveAsync
			(T entity, System.Threading.CancellationToken cancellationToken = default);

		System.Threading.Tasks.Task RemoveRangeAsync
			(System.Collections.Generic.IEnumerable<T>
			entities, System.Threading.CancellationToken cancellationToken = default);

		System.Threading.Tasks.Task<bool> RemoveByIdAsync
			(System.Guid id, System.Threading.CancellationToken cancellationToken = default);

		System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<T>>
			GetAllAsync(System.Threading.CancellationToken cancellationToken = default);

		System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<T>>
			Find(System.Linq.Expressions.Expression<System.Func<T, bool>>
			predicate, System.Threading.CancellationToken cancellationToken = default);

		System.Threading.Tasks.Task<T> FindAsync
			(System.Guid id, System.Threading.CancellationToken cancellationToken = default);
	}
}
