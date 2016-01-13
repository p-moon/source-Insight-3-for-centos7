public interface IRevertibleChangeTracking : IChangeTracking
{

	// Methods
	public abstract virtual void RejectChanges() {}
}

