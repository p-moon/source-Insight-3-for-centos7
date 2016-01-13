public interface IChangeTracking
{

	// Methods
	public abstract virtual void AcceptChanges() {}

	// Properties
	public bool IsChanged { get{} }
}

