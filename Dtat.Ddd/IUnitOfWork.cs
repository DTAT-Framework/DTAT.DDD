namespace Dtat.Ddd
{
	public interface IUnitOfWork : System.IDisposable
	{
		bool IsDisposed { get; }

		System.Threading.Tasks.Task<int> SaveAsync();
	}
}
