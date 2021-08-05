namespace Dtat.Ddd
{
	public interface IAggregateRoot : IEntity
	{
		void ClearDomainEvents();

		System.Collections.Generic.IReadOnlyList<IDomainEvent> DomainEvents { get; }
	}
}
