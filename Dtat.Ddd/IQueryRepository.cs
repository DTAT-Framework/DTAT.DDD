namespace Dtat.Ddd
{
	public interface IQueryRepository<T> where T : IAggregateRoot
	{
		System.Threading.Tasks.Task<System.Collections.Generic.IList<T>>
			GetAllAsync(System.Threading.CancellationToken cancellationToken = default);

		System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<T>>
			Find(System.Linq.Expressions.Expression<System.Func<T, bool>>
			predicate, System.Threading.CancellationToken cancellationToken = default);

		System.Threading.Tasks.Task<T> FindAsync
			(System.Guid id, System.Threading.CancellationToken cancellationToken = default);
	}
}
